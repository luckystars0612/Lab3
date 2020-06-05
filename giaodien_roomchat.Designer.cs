namespace Lập_trình_mạng___Lab3
{
    partial class giaodien_roomchat
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
            this.ListofRoom_lv = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomName_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomID_create_tb = new System.Windows.Forms.TextBox();
            this.create_chat_bt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomID_join_tb = new System.Windows.Forms.TextBox();
            this.joinroom_bt = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListofRoom_lv
            // 
            this.ListofRoom_lv.HideSelection = false;
            this.ListofRoom_lv.Location = new System.Drawing.Point(335, 19);
            this.ListofRoom_lv.Name = "ListofRoom_lv";
            this.ListofRoom_lv.Size = new System.Drawing.Size(335, 330);
            this.ListofRoom_lv.TabIndex = 9;
            this.ListofRoom_lv.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.roomName_tb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.roomID_create_tb);
            this.groupBox2.Controls.Add(this.create_chat_bt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 153);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create a team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Room Name";
            // 
            // roomName_tb
            // 
            this.roomName_tb.Location = new System.Drawing.Point(103, 73);
            this.roomName_tb.Name = "roomName_tb";
            this.roomName_tb.Size = new System.Drawing.Size(176, 22);
            this.roomName_tb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room ID";
            // 
            // roomID_create_tb
            // 
            this.roomID_create_tb.Location = new System.Drawing.Point(103, 36);
            this.roomID_create_tb.Name = "roomID_create_tb";
            this.roomID_create_tb.Size = new System.Drawing.Size(176, 22);
            this.roomID_create_tb.TabIndex = 5;
            // 
            // create_chat_bt
            // 
            this.create_chat_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_chat_bt.Location = new System.Drawing.Point(93, 110);
            this.create_chat_bt.Name = "create_chat_bt";
            this.create_chat_bt.Size = new System.Drawing.Size(97, 37);
            this.create_chat_bt.TabIndex = 4;
            this.create_chat_bt.Text = "Create";
            this.create_chat_bt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.roomID_join_tb);
            this.groupBox1.Controls.Add(this.joinroom_bt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 153);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Join a team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room ID";
            // 
            // roomID_join_tb
            // 
            this.roomID_join_tb.Location = new System.Drawing.Point(93, 43);
            this.roomID_join_tb.Name = "roomID_join_tb";
            this.roomID_join_tb.Size = new System.Drawing.Size(176, 22);
            this.roomID_join_tb.TabIndex = 2;
            // 
            // joinroom_bt
            // 
            this.joinroom_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinroom_bt.Location = new System.Drawing.Point(93, 87);
            this.joinroom_bt.Name = "joinroom_bt";
            this.joinroom_bt.Size = new System.Drawing.Size(97, 37);
            this.joinroom_bt.TabIndex = 0;
            this.joinroom_bt.Text = "Join";
            this.joinroom_bt.UseVisualStyleBackColor = true;
            // 
            // giaodien_roomchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 369);
            this.Controls.Add(this.ListofRoom_lv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "giaodien_roomchat";
            this.Text = "giaodien_roomchat";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListofRoom_lv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomName_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomID_create_tb;
        private System.Windows.Forms.Button create_chat_bt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomID_join_tb;
        private System.Windows.Forms.Button joinroom_bt;
    }
}