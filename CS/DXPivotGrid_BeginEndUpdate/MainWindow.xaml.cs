using System;
using System.Data;
using System.Windows;
using DevExpress.Xpf.PivotGrid;

namespace DXPivotGrid_BeginEndUpdate {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = GetDataTable();
        }
        private void btnRun_Click(object sender, RoutedEventArgs e) {
            DateTime startTime = DateTime.Now;

            // If an appropriate option is enabled, 
            // locks the pivot grid to prevent further updates.
            if (rbLocked.IsChecked == true) pivotGridControl1.BeginUpdate();
            try {

                // Initiates transposition.
                Transpose();
            }
            finally {

                // If the pivot grid has been locked, unlocks it, allowing further updates.
                if (rbLocked.IsChecked == true) pivotGridControl1.EndUpdate();
            }

            // Displays the amount of time taken by the transposition.
            TimeSpan duration = DateTime.Now - startTime;
            MessageBox.Show("Transposition took " +
                duration.TotalSeconds.ToString("F2") + " seconds");
        }

        // Transposes the pivot grid by moving Row Fields to the Column Area, and vice versa.
        private void Transpose() {
            foreach (PivotGridField field in pivotGridControl1.Fields) {
                if (field.Area == FieldArea.RowArea)
                    field.Area = FieldArea.ColumnArea;
                else if (field.Area == FieldArea.ColumnArea)
                    field.Area = FieldArea.RowArea;
            }
        }

        // Generates pivot grid data.
        public static DataTable GetDataTable() {
            DataTable table = new DataTable();
            table.Columns.Add("A", typeof(string));
            table.Columns.Add("B", typeof(string));
            table.Columns.Add("Data", typeof(int));
            for (int i = 0; i < 1000; i++)
                for (int j = 0; j < 500; j++)
                    table.Rows.Add('A' + i.ToString(), 'B' + j.ToString(), ((int)i / 100));
            return table;
        }
    }
}
