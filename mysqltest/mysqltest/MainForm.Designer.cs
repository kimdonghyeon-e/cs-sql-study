namespace mysqltest
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbID = new System.Windows.Forms.Label();
            this.lbPW = new System.Windows.Forms.Label();
            this.lbDB = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.lbTable = new System.Windows.Forms.Label();
            this.tbTable = new System.Windows.Forms.TextBox();
            this.btConn = new System.Windows.Forms.Button();
            this.btDisconn = new System.Windows.Forms.Button();
            this.dgvReadData = new System.Windows.Forms.DataGridView();
            this.gvRead = new System.Windows.Forms.GroupBox();
            this.lbRead = new System.Windows.Forms.Label();
            this.btRead = new System.Windows.Forms.Button();
            this.gbWrite = new System.Windows.Forms.GroupBox();
            this.lbWrInfo = new System.Windows.Forms.Label();
            this.tbData3 = new System.Windows.Forms.TextBox();
            this.tbData2 = new System.Windows.Forms.TextBox();
            this.tbData1 = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.gbConn = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadData)).BeginInit();
            this.gvRead.SuspendLayout();
            this.gbWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(39, 156);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(31, 25);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID";
            // 
            // lbPW
            // 
            this.lbPW.AutoSize = true;
            this.lbPW.Location = new System.Drawing.Point(39, 225);
            this.lbPW.Name = "lbPW";
            this.lbPW.Size = new System.Drawing.Size(45, 25);
            this.lbPW.TabIndex = 2;
            this.lbPW.Text = "PW";
            // 
            // lbDB
            // 
            this.lbDB.AutoSize = true;
            this.lbDB.Location = new System.Drawing.Point(39, 291);
            this.lbDB.Name = "lbDB";
            this.lbDB.Size = new System.Drawing.Size(39, 25);
            this.lbDB.TabIndex = 3;
            this.lbDB.Text = "DB";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(125, 156);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 29);
            this.tbID.TabIndex = 1;
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(125, 221);
            this.tbPW.Name = "tbPW";
            this.tbPW.Size = new System.Drawing.Size(100, 29);
            this.tbPW.TabIndex = 2;
            this.tbPW.UseSystemPasswordChar = true;
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(125, 291);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(100, 29);
            this.tbDB.TabIndex = 3;
            // 
            // lbTable
            // 
            this.lbTable.AutoSize = true;
            this.lbTable.Location = new System.Drawing.Point(39, 364);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(62, 25);
            this.lbTable.TabIndex = 7;
            this.lbTable.Text = "Table";
            // 
            // tbTable
            // 
            this.tbTable.Location = new System.Drawing.Point(125, 364);
            this.tbTable.Name = "tbTable";
            this.tbTable.Size = new System.Drawing.Size(100, 29);
            this.tbTable.TabIndex = 4;
            // 
            // btConn
            // 
            this.btConn.Location = new System.Drawing.Point(102, 437);
            this.btConn.Name = "btConn";
            this.btConn.Size = new System.Drawing.Size(135, 41);
            this.btConn.TabIndex = 5;
            this.btConn.Text = "Connect";
            this.btConn.UseVisualStyleBackColor = true;
            this.btConn.Click += new System.EventHandler(this.btConn_Click);
            // 
            // btDisconn
            // 
            this.btDisconn.Enabled = false;
            this.btDisconn.Location = new System.Drawing.Point(102, 494);
            this.btDisconn.Name = "btDisconn";
            this.btDisconn.Size = new System.Drawing.Size(135, 43);
            this.btDisconn.TabIndex = 11;
            this.btDisconn.Text = "Disconnect";
            this.btDisconn.UseVisualStyleBackColor = true;
            this.btDisconn.Click += new System.EventHandler(this.btDisconn_Click);
            // 
            // dgvReadData
            // 
            this.dgvReadData.Location = new System.Drawing.Point(21, 77);
            this.dgvReadData.Name = "dgvReadData";
            this.dgvReadData.RowTemplate.Height = 31;
            this.dgvReadData.Size = new System.Drawing.Size(826, 602);
            this.dgvReadData.TabIndex = 13;
            // 
            // gvRead
            // 
            this.gvRead.Controls.Add(this.lbRead);
            this.gvRead.Controls.Add(this.btRead);
            this.gvRead.Controls.Add(this.dgvReadData);
            this.gvRead.Location = new System.Drawing.Point(336, 273);
            this.gvRead.Name = "gvRead";
            this.gvRead.Size = new System.Drawing.Size(862, 694);
            this.gvRead.TabIndex = 14;
            this.gvRead.TabStop = false;
            this.gvRead.Text = "Read";
            // 
            // lbRead
            // 
            this.lbRead.AutoSize = true;
            this.lbRead.Location = new System.Drawing.Point(54, 31);
            this.lbRead.Name = "lbRead";
            this.lbRead.Size = new System.Drawing.Size(0, 25);
            this.lbRead.TabIndex = 17;
            // 
            // btRead
            // 
            this.btRead.Enabled = false;
            this.btRead.Location = new System.Drawing.Point(345, 24);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(111, 38);
            this.btRead.TabIndex = 10;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // gbWrite
            // 
            this.gbWrite.Controls.Add(this.lbWrInfo);
            this.gbWrite.Controls.Add(this.tbData3);
            this.gbWrite.Controls.Add(this.tbData2);
            this.gbWrite.Controls.Add(this.tbData1);
            this.gbWrite.Controls.Add(this.btSend);
            this.gbWrite.Location = new System.Drawing.Point(336, 75);
            this.gbWrite.Name = "gbWrite";
            this.gbWrite.Size = new System.Drawing.Size(483, 192);
            this.gbWrite.TabIndex = 15;
            this.gbWrite.TabStop = false;
            this.gbWrite.Text = "Write";
            // 
            // lbWrInfo
            // 
            this.lbWrInfo.AutoSize = true;
            this.lbWrInfo.Location = new System.Drawing.Point(54, 141);
            this.lbWrInfo.Name = "lbWrInfo";
            this.lbWrInfo.Size = new System.Drawing.Size(0, 25);
            this.lbWrInfo.TabIndex = 19;
            // 
            // tbData3
            // 
            this.tbData3.Location = new System.Drawing.Point(345, 77);
            this.tbData3.Name = "tbData3";
            this.tbData3.Size = new System.Drawing.Size(100, 29);
            this.tbData3.TabIndex = 8;
            // 
            // tbData2
            // 
            this.tbData2.Location = new System.Drawing.Point(201, 77);
            this.tbData2.Name = "tbData2";
            this.tbData2.Size = new System.Drawing.Size(100, 29);
            this.tbData2.TabIndex = 7;
            // 
            // tbData1
            // 
            this.tbData1.Location = new System.Drawing.Point(59, 77);
            this.tbData1.Name = "tbData1";
            this.tbData1.Size = new System.Drawing.Size(100, 29);
            this.tbData1.TabIndex = 6;
            // 
            // btSend
            // 
            this.btSend.Enabled = false;
            this.btSend.Location = new System.Drawing.Point(345, 132);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(111, 43);
            this.btSend.TabIndex = 9;
            this.btSend.Text = "Write";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // gbConn
            // 
            this.gbConn.Location = new System.Drawing.Point(35, 75);
            this.gbConn.Name = "gbConn";
            this.gbConn.Size = new System.Drawing.Size(282, 485);
            this.gbConn.TabIndex = 16;
            this.gbConn.TabStop = false;
            this.gbConn.Text = "Connect";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 1006);
            this.Controls.Add(this.gbWrite);
            this.Controls.Add(this.gvRead);
            this.Controls.Add(this.btDisconn);
            this.Controls.Add(this.btConn);
            this.Controls.Add(this.tbTable);
            this.Controls.Add(this.lbTable);
            this.Controls.Add(this.tbDB);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbDB);
            this.Controls.Add(this.lbPW);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.gbConn);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadData)).EndInit();
            this.gvRead.ResumeLayout(false);
            this.gvRead.PerformLayout();
            this.gbWrite.ResumeLayout(false);
            this.gbWrite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPW;
        private System.Windows.Forms.Label lbDB;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.TextBox tbTable;
        private System.Windows.Forms.Button btConn;
        private System.Windows.Forms.Button btDisconn;
        private System.Windows.Forms.DataGridView dgvReadData;
        private System.Windows.Forms.GroupBox gvRead;
        private System.Windows.Forms.GroupBox gbWrite;
        private System.Windows.Forms.TextBox tbData3;
        private System.Windows.Forms.TextBox tbData2;
        private System.Windows.Forms.TextBox tbData1;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.GroupBox gbConn;
        private System.Windows.Forms.Label lbWrInfo;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label lbRead;
    }
}

