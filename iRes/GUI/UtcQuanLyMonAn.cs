﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Title.Config;
using Title.BUS;
using Title.Lib;
using System.Data.SqlClient;

namespace Title.GUI
{
    public partial class UtcQuanLyMonAn : UserControl
    {
        Configuration config = new Configuration();
        SqlConnection conn;

        public UtcQuanLyMonAn() {
            InitializeComponent();
        }

        public void TaoKetNoi() {
            conn = new SqlConnection(config.DATA_SOURCE);
            conn.Open();
        }

        public void LoadData() {
            TaoKetNoi();
            DataTable dt = LoadDataTable();
            gridControlMonAn.DataSource = dt;
            RepositoryItemGraphicsEdit repItemGraphicsEdit = new RepositoryItemGraphicsEdit();

            repItemGraphicsEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            repItemGraphicsEdit.BestFitWidth = 100;
            layoutView1.Columns["Hình ảnh"].ColumnEdit = repItemGraphicsEdit;
        }

        public DataTable LoadDataTable() {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(config.GET_LIST_MONAN_AND_IMAGE, conn);
            da.Fill(dt);
            return dt;
        }

        private void UtcQuanLyMonAn_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void layoutView1_Click(object sender, EventArgs e)
        {
            
        }

        private void layoutView1_CardClick(object sender, DevExpress.XtraGrid.Views.Layout.Events.CardClickEventArgs e)
        {
           
       
                //do something;  
                MessageBox.Show("","");
            
        }

    }
}
