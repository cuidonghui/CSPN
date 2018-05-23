﻿namespace CSPN.control
{
    partial class StatementManageControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatementManageControl));
            this.btnSysOut = new System.Windows.Forms.Button();
            this.btnUserWellInfoOut = new System.Windows.Forms.Button();
            this.btnUserGeneralInfoOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSysOut
            // 
            this.btnSysOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSysOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSysOut.BackgroundImage")));
            this.btnSysOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSysOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSysOut.FlatAppearance.BorderSize = 0;
            this.btnSysOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSysOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSysOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSysOut.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSysOut.ForeColor = System.Drawing.Color.White;
            this.btnSysOut.Location = new System.Drawing.Point(10, 37);
            this.btnSysOut.Name = "btnSysOut";
            this.btnSysOut.Size = new System.Drawing.Size(179, 26);
            this.btnSysOut.TabIndex = 15;
            this.btnSysOut.Text = "系统日志导出(Excel)";
            this.btnSysOut.UseVisualStyleBackColor = true;
            this.btnSysOut.Click += new System.EventHandler(this.btnSysOut_Click);
            // 
            // btnUserWellInfoOut
            // 
            this.btnUserWellInfoOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserWellInfoOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserWellInfoOut.BackgroundImage")));
            this.btnUserWellInfoOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserWellInfoOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserWellInfoOut.FlatAppearance.BorderSize = 0;
            this.btnUserWellInfoOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUserWellInfoOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUserWellInfoOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserWellInfoOut.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserWellInfoOut.ForeColor = System.Drawing.Color.White;
            this.btnUserWellInfoOut.Location = new System.Drawing.Point(209, 37);
            this.btnUserWellInfoOut.Name = "btnUserWellInfoOut";
            this.btnUserWellInfoOut.Size = new System.Drawing.Size(179, 26);
            this.btnUserWellInfoOut.TabIndex = 16;
            this.btnUserWellInfoOut.Text = "人井操作日志导出(Excel)";
            this.btnUserWellInfoOut.UseVisualStyleBackColor = true;
            this.btnUserWellInfoOut.Click += new System.EventHandler(this.btnUserWellInfoOut_Click);
            // 
            // btnUserGeneralInfoOut
            // 
            this.btnUserGeneralInfoOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserGeneralInfoOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserGeneralInfoOut.BackgroundImage")));
            this.btnUserGeneralInfoOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserGeneralInfoOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserGeneralInfoOut.FlatAppearance.BorderSize = 0;
            this.btnUserGeneralInfoOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUserGeneralInfoOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUserGeneralInfoOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserGeneralInfoOut.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserGeneralInfoOut.ForeColor = System.Drawing.Color.White;
            this.btnUserGeneralInfoOut.Location = new System.Drawing.Point(409, 37);
            this.btnUserGeneralInfoOut.Name = "btnUserGeneralInfoOut";
            this.btnUserGeneralInfoOut.Size = new System.Drawing.Size(179, 26);
            this.btnUserGeneralInfoOut.TabIndex = 17;
            this.btnUserGeneralInfoOut.Text = "一般用户日志导出(Excel)";
            this.btnUserGeneralInfoOut.UseVisualStyleBackColor = true;
            this.btnUserGeneralInfoOut.Click += new System.EventHandler(this.btnUserGeneralInfoOut_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnSysOut, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUserWellInfoOut, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUserGeneralInfoOut, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 426);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // StatementManageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "StatementManageControl";
            this.Size = new System.Drawing.Size(600, 426);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void WellGridInitializeComponent()
        {

            System.Windows.Forms.DataGridView wellGrid = new System.Windows.Forms.DataGridView();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();

            // 
            // wellGrid
            // 
            wellGrid.AllowUserToAddRows = false;
            wellGrid.AllowUserToDeleteRows = false;
            wellGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            wellGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            wellGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            wellGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            wellGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            wellGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            wellGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            wellGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            wellGrid.ColumnHeadersHeight = 30;
            wellGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            wellGrid.GridColor = System.Drawing.Color.Blue;
            wellGrid.MultiSelect = false;
            wellGrid.Name = "wellGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            wellGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            wellGrid.RowHeadersVisible = false;
            wellGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            wellGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            wellGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            wellGrid.RowTemplate.Height = 35;
            wellGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }

        #endregion

        private System.Windows.Forms.Button btnSysOut;
        private System.Windows.Forms.Button btnUserWellInfoOut;
        private System.Windows.Forms.Button btnUserGeneralInfoOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}