namespace WindowsFormsLibrarySystem
{
    partial class FrmChangePwd
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPwd = new System.Windows.Forms.GroupBox();
            this.tlpPwd = new System.Windows.Forms.TableLayoutPanel();
            this.lblOldPwd = new System.Windows.Forms.Label();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbPwd.SuspendLayout();
            this.tlpPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPwd
            // 
            this.gbPwd.BackColor = System.Drawing.Color.White;
            this.gbPwd.Controls.Add(this.tlpPwd);
            this.gbPwd.Location = new System.Drawing.Point(14, 12);
            this.gbPwd.Name = "gbPwd";
            this.gbPwd.Size = new System.Drawing.Size(372, 200);
            this.gbPwd.TabIndex = 0;
            this.gbPwd.TabStop = false;
            this.gbPwd.Text = "修改密码";
            // 
            // tlpPwd
            // 
            this.tlpPwd.ColumnCount = 2;
            this.tlpPwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpPwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPwd.Controls.Add(this.lblOldPwd, 0, 0);
            this.tlpPwd.Controls.Add(this.txtOldPwd, 1, 0);
            this.tlpPwd.Controls.Add(this.lblNewPwd, 0, 1);
            this.tlpPwd.Controls.Add(this.txtNewPwd, 1, 1);
            this.tlpPwd.Controls.Add(this.lblConfirmPwd, 0, 2);
            this.tlpPwd.Controls.Add(this.txtConfirmPwd, 1, 2);
            this.tlpPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPwd.Location = new System.Drawing.Point(3, 21);
            this.tlpPwd.Name = "tlpPwd";
            this.tlpPwd.Padding = new System.Windows.Forms.Padding(16, 18, 16, 12);
            this.tlpPwd.RowCount = 3;
            this.tlpPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpPwd.Size = new System.Drawing.Size(366, 176);
            this.tlpPwd.TabIndex = 0;
            // 
            // lblOldPwd
            // 
            this.lblOldPwd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOldPwd.AutoSize = true;
            this.lblOldPwd.Location = new System.Drawing.Point(22, 28);
            this.lblOldPwd.Name = "lblOldPwd";
            this.lblOldPwd.Size = new System.Drawing.Size(64, 17);
            this.lblOldPwd.TabIndex = 0;
            this.lblOldPwd.Text = "原密码：";
            this.lblOldPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldPwd.Location = new System.Drawing.Point(115, 24);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(232, 25);
            this.txtOldPwd.TabIndex = 1;
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Location = new System.Drawing.Point(22, 75);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(64, 17);
            this.lblNewPwd.TabIndex = 2;
            this.lblNewPwd.Text = "新密码：";
            this.lblNewPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPwd.Location = new System.Drawing.Point(115, 71);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(232, 25);
            this.txtNewPwd.TabIndex = 3;
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblConfirmPwd.AutoSize = true;
            this.lblConfirmPwd.Location = new System.Drawing.Point(6, 122);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(80, 17);
            this.lblConfirmPwd.TabIndex = 4;
            this.lblConfirmPwd.Text = "确认新密码：";
            this.lblConfirmPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPwd.Location = new System.Drawing.Point(115, 118);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(232, 25);
            this.txtConfirmPwd.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(96, 234);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 34);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnCancel.Location = new System.Drawing.Point(208, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // FrmChangePwd
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(400, 288);
            this.ControlBox = false;
            this.Controls.Add(this.gbPwd);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangePwd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.gbPwd.ResumeLayout(false);
            this.tlpPwd.ResumeLayout(false);
            this.tlpPwd.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbPwd;
        private System.Windows.Forms.TableLayoutPanel tlpPwd;
        private System.Windows.Forms.Label lblOldPwd;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label lblConfirmPwd;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
