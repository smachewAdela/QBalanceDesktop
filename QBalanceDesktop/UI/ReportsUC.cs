using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace QBalanceDesktop.UI
{
    public enum ReportTypeEnum
    {
        [Description("פרטי קטגוריה")]
        CategoryDetails,
        [Description("פרטי קבוצה")]
        GroupDetails,
        [Description("סיכות תקציב")]
        BudgetDetails,
        [Description("סיכום הכנסות")]
        IncomeDetails
    }
    public partial class ReportsUC : UserControl
    {
        public ReportsUC()
        {
            InitializeComponent();
            FillReportsCombo();
        }

        private void FillReportsCombo()
        {
            cmbReportType.Items.Clear();
            foreach (ReportTypeEnum reportTypeEnum in Enum.GetValues(typeof(ReportTypeEnum)))
            {
                cmbReportType.Items.Add(new ListItem { Display = reportTypeEnum.GetEnumDescription(), Key = (int)reportTypeEnum, ExtraData = reportTypeEnum });
            }
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReportType.HasSelection())
            {
                RefreshView((ReportTypeEnum)(cmbReportType.SelectedItem as ListItem).ExtraData);
            }
        }

        private void RefreshView(ReportTypeEnum reportTypeEnum)
        {
            DataTable tbl = new DataTable();
            var months = GlobalsProviderBL.Db.GetData<Budget>();
            FillColumns(tbl, reportTypeEnum);
            switch (reportTypeEnum)
            {
                case ReportTypeEnum.CategoryDetails:
                    FillCategoryDetails(tbl, months);
                    break;
                case ReportTypeEnum.GroupDetails:
                    FillGroupDetails(tbl, months);
                    break;
                case ReportTypeEnum.BudgetDetails:
                    FillBudgetDetails(tbl, months);
                    break;
                case ReportTypeEnum.IncomeDetails:
                    FillIncomeDetails(tbl, months);
                    break;
                default:
                    break;
            }

            dgvReports.DataSource = tbl;
            
        }

        private void FillIncomeDetails(DataTable tbl, List<Budget> months)
        {
            var currentMonth = months.OrderByDescending(x => x.Month).First();
            months.Remove(currentMonth);

            var row = tbl.NewRow();
            row[0] = "הכנסות";
            row[1] = months.Count;
            row[2] = ((int)months.Average(x => x.TotalIncomes)).ToNumberFormat();
            row[3] = ((int)months.Average(x => x.TotalIncomes - x.TotalExpenses)).ToNumberFormat();
            row[4] = ((int)months.Sum(x => x.TotalIncomes) - months.Sum(x => x.TotalExpenses)).ToNumberFormat();
            tbl.Rows.Add(row);
        }

        private void FillBudgetDetails(DataTable tbl, List<Budget> months)
        {
        
            var currentMonth = months.OrderByDescending(x => x.Month).First();
            months.Remove(currentMonth);

            var allRow = tbl.NewRow();
            allRow[0] = "תקציב - כללי";
            allRow[1] = currentMonth.TotalBudget.ToNumberFormat();
            allRow[2] = ((int)months.Average(x => x.TotalExpenses)).ToNumberFormat();

            allRow[3] = ((int)months.Sum(x => x.OverSpentNumber)).ToNumberFormat();
            allRow[4] = ((int)months.Sum(x => x.TotalBudget) - months.Sum(x => x.TotalExpenses)).ToNumberFormat();

            //allRow[5] = $"{ ((int)months.Sum(x => x.TotalBudget) - months.Sum(x => x.TotalExpenses)) }";
            var ration = (months.Sum(x => x.TotalExpenses) * 100) / months.Sum(x => x.TotalBudget);
            allRow[5] = $"{ ration }%";
            tbl.Rows.Add(allRow);

            var currentMonthRow = tbl.NewRow();
            currentMonthRow[0] = "חודש נוכחי";
            currentMonthRow[1] = currentMonth.TotalBudget.ToNumberFormat();
            currentMonthRow[2] = currentMonth.TotalExpenses.ToNumberFormat();
            currentMonthRow[3] = currentMonth.OverSpentNumber.ToNumberFormat();

            currentMonthRow[4] = ((int)currentMonth.TotalBudget - currentMonth.TotalExpenses).ToNumberFormat();

            ration = (currentMonth.TotalExpenses * 100) / currentMonth.TotalBudget;
            currentMonthRow[5] = $"{ ration }%";

            tbl.Rows.Add(currentMonthRow);
        }

        private void FillGroupDetails(DataTable tbl, List<Budget> months)
        {
            var groups = GlobalsProviderBL.Db.GetData<BudgetGroup>();
            var currentMonth = months.OrderByDescending(x => x.Month).First();
            foreach (var g in groups)
            {
                var row = tbl.NewRow();
                row[0] = g.Name;
                row[1] = currentMonth.Items.Where(x => x.GroupId == g.Id).Sum(x => x.BudgetAmount).ToNumberFormat();
                row[2] = ((int)months.Average(x => x.GroupStatusData[g.Id])).ToNumberFormat();
                row[3] = ((int)months.Sum(x => x.GroupOverSpentData[g.Id])).ToNumberFormat();
                row[4] = ((int)months.Sum(x => x.GroupBudgetData[g.Id])   - months.Sum(x => x.GroupStatusData[g.Id])).ToNumberFormat();

                var ration = (months.Sum(x => x.GroupStatusData[g.Id]) * 100) / months.Sum(x => x.GroupBudgetData[g.Id]);
                row[5] = $"{ ration }%";
                tbl.Rows.Add(row);
            }
        }

        private void FillCategoryDetails(DataTable tbl, List<Budget> months)
        {
            var categories = GlobalsProviderBL.Db.GetData<BudgetItem>();
            var currentMonth = months.OrderByDescending(x => x.Month).First();
            months.Remove(currentMonth);

            foreach (var c in currentMonth.Items.Where(x => x.Active).ToList())
            {
                var allCategoryInstances = categories.Where(x => x.CategoryName == c.CategoryName).ToList();

                var row = tbl.NewRow();
                row[0] = c.CategoryName;
                row[1] = c.BudgetAmount.ToNumberFormat();
                row[2] = ((int)allCategoryInstances.Average(x => x.StatusAmount)).ToNumberFormat();
                row[3] = ((int)allCategoryInstances.Sum(x => x.OverSpent)).ToNumberFormat();
                row[4] = ((int)allCategoryInstances.Sum(x => x.BudgetAmount) - allCategoryInstances.Sum(x => x.StatusAmount)).ToNumberFormat();

                if (allCategoryInstances.Sum(x => x.BudgetAmount) > 0)
                {
                    var ration = (allCategoryInstances.Sum(x => x.StatusAmount) * 100) / allCategoryInstances.Sum(x => x.BudgetAmount);
                    row[5] = $"{ ration }%";
                }
                else
                    row[5] = string.Empty;
            
                tbl.Rows.Add(row);
            }
        }

        private void FillColumns(DataTable tbl, ReportTypeEnum reportTypeEnum)
        {
            switch (reportTypeEnum)
            {
                case ReportTypeEnum.CategoryDetails:
                case ReportTypeEnum.GroupDetails:
                case ReportTypeEnum.BudgetDetails:
                    tbl.Columns.Add("שם");
                    tbl.Columns.Add("תקציב");
                    tbl.Columns.Add("ממוצע");
                    tbl.Columns.Add("חריגות");
                    tbl.Columns.Add("מאזן");
                    tbl.Columns.Add("ניצול");
                    break;

                case ReportTypeEnum.IncomeDetails:
                    tbl.Columns.Add(" ");
                    tbl.Columns.Add("חודשים");
                    tbl.Columns.Add("ממוצע");
                    tbl.Columns.Add("יתרה חודשית ממוצעת");
                    //tbl.Columns.Add("מאזן");
                    tbl.Columns.Add("יתרה כוללת");
                    break;
              
                default:
                    break;
            }
        }

        private void dgvReports_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dgvReports.Rows[e.RowIndex];// get you required index
                                                         // check the cell value under your specific column and then you can toggle your colors
            row.DefaultCellStyle.BackColor = Color.Black;
            row.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
