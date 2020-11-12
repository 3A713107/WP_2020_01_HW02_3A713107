namespace WP_2020_01_HW02_3A713107
{
    partial class frmGame
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGO = new System.Windows.Forms.Button();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGO
            // 
            this.btnGO.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGO.Location = new System.Drawing.Point(473, 43);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(135, 108);
            this.btnGO.TabIndex = 0;
            this.btnGO.Text = "抽";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // rtbMsg
            // 
            this.rtbMsg.Location = new System.Drawing.Point(109, 125);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(210, 267);
            this.rtbMsg.TabIndex = 2;
            this.rtbMsg.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(159, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "歷程";
            // 
            // btnDraw
            // 
            this.btnDraw.Image = global::WP_2020_01_HW02_3A713107.Properties.Resources._001;
            this.btnDraw.Location = new System.Drawing.Point(427, 175);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(234, 217);
            this.btnDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDraw.TabIndex = 4;
            this.btnDraw.TabStop = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbMsg);
            this.Controls.Add(this.btnGO);
            this.Name = "frmGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGame_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.btnDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.RichTextBox rtbMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnDraw;
    }
}

