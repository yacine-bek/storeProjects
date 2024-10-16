namespace storeProjects
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button_F2 = new Button();
            button_F1 = new Button();
            panel_F1 = new Panel();
            groupBox_F1 = new GroupBox();
            panel_F2 = new Panel();
            groupBox_F2 = new GroupBox();
            panel_add = new Panel();
            cancel_adding = new Button();
            special_check = new CheckBox();
            name_input = new TextBox();
            label3 = new Label();
            price_input = new TextBox();
            label2 = new Label();
            barcode_input = new TextBox();
            label1 = new Label();
            button_done = new Button();
            add_button = new Button();
            input_barcode = new TextBox();
            button_next = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            price_output = new TextBox();
            panel_special = new Panel();
            groupBox_special = new GroupBox();
            button_sub = new Button();
            button_add = new Button();
            label4 = new Label();
            panel_F1.SuspendLayout();
            panel_F2.SuspendLayout();
            panel_add.SuspendLayout();
            panel_special.SuspendLayout();
            SuspendLayout();
            // 
            // button_F2
            // 
            button_F2.Location = new Point(115, 15);
            button_F2.Name = "button_F2";
            button_F2.Size = new Size(100, 35);
            button_F2.TabIndex = 7;
            button_F2.Text = "F2";
            button_F2.UseVisualStyleBackColor = true;
            button_F2.Click += button_F2_Click;
            // 
            // button_F1
            // 
            button_F1.Location = new Point(15, 15);
            button_F1.Name = "button_F1";
            button_F1.Size = new Size(100, 35);
            button_F1.TabIndex = 6;
            button_F1.Text = "F1";
            button_F1.UseVisualStyleBackColor = true;
            button_F1.Click += button_F1_Click;
            // 
            // panel_F1
            // 
            panel_F1.BackColor = SystemColors.ButtonShadow;
            panel_F1.Controls.Add(groupBox_F1);
            panel_F1.Location = new Point(15, 47);
            panel_F1.Name = "panel_F1";
            panel_F1.Size = new Size(830, 530);
            panel_F1.TabIndex = 10;
            panel_F1.Paint += panel_F2_Paint;
            // 
            // groupBox_F1
            // 
            groupBox_F1.Location = new Point(15, 15);
            groupBox_F1.Name = "groupBox_F1";
            groupBox_F1.Size = new Size(800, 500);
            groupBox_F1.TabIndex = 5;
            groupBox_F1.TabStop = false;
            // 
            // panel_F2
            // 
            panel_F2.BackColor = SystemColors.ButtonShadow;
            panel_F2.Controls.Add(groupBox_F2);
            panel_F2.Location = new Point(15, 47);
            panel_F2.Name = "panel_F2";
            panel_F2.Size = new Size(830, 530);
            panel_F2.TabIndex = 22;
            // 
            // groupBox_F2
            // 
            groupBox_F2.Location = new Point(15, 15);
            groupBox_F2.Name = "groupBox_F2";
            groupBox_F2.Size = new Size(800, 500);
            groupBox_F2.TabIndex = 5;
            groupBox_F2.TabStop = false;
            // 
            // panel_add
            // 
            panel_add.BackColor = SystemColors.ButtonShadow;
            panel_add.Controls.Add(cancel_adding);
            panel_add.Controls.Add(special_check);
            panel_add.Controls.Add(name_input);
            panel_add.Controls.Add(label3);
            panel_add.Controls.Add(price_input);
            panel_add.Controls.Add(label2);
            panel_add.Controls.Add(barcode_input);
            panel_add.Controls.Add(label1);
            panel_add.Controls.Add(button_done);
            panel_add.Location = new Point(940, 15);
            panel_add.Name = "panel_add";
            panel_add.Size = new Size(250, 200);
            panel_add.TabIndex = 14;
            // 
            // cancel_adding
            // 
            cancel_adding.Location = new Point(147, 162);
            cancel_adding.Name = "cancel_adding";
            cancel_adding.Size = new Size(100, 35);
            cancel_adding.TabIndex = 17;
            cancel_adding.Text = "Cancel";
            cancel_adding.UseVisualStyleBackColor = true;
            cancel_adding.Click += cancel_adding_Click;
            // 
            // special_check
            // 
            special_check.AutoSize = true;
            special_check.Location = new Point(3, 137);
            special_check.Name = "special_check";
            special_check.Size = new Size(67, 19);
            special_check.TabIndex = 7;
            special_check.Text = "special?";
            special_check.UseVisualStyleBackColor = true;
            special_check.CheckedChanged += special_check_CheckedChanged;
            // 
            // name_input
            // 
            name_input.Font = new Font("Segoe UI", 10F);
            name_input.Location = new Point(3, 64);
            name_input.Name = "name_input";
            name_input.Size = new Size(244, 25);
            name_input.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 46);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 5;
            label3.Text = "Enter The name of Products:";
            // 
            // price_input
            // 
            price_input.Font = new Font("Segoe UI", 10F);
            price_input.Location = new Point(3, 110);
            price_input.Name = "price_input";
            price_input.Size = new Size(244, 25);
            price_input.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 92);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter The Price:";
            // 
            // barcode_input
            // 
            barcode_input.Font = new Font("Segoe UI", 10F);
            barcode_input.Location = new Point(3, 18);
            barcode_input.Name = "barcode_input";
            barcode_input.Size = new Size(244, 25);
            barcode_input.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter Bar Code:";
            // 
            // button_done
            // 
            button_done.Location = new Point(3, 162);
            button_done.Name = "button_done";
            button_done.Size = new Size(100, 35);
            button_done.TabIndex = 0;
            button_done.Text = "Done";
            button_done.UseVisualStyleBackColor = true;
            button_done.Click += button_done_Click;
            // 
            // add_button
            // 
            add_button.Location = new Point(1208, 15);
            add_button.Name = "add_button";
            add_button.Size = new Size(150, 50);
            add_button.TabIndex = 11;
            add_button.Text = "ADD element";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // input_barcode
            // 
            input_barcode.Font = new Font("Segoe UI", 20F);
            input_barcode.Location = new Point(1208, 71);
            input_barcode.Name = "input_barcode";
            input_barcode.Size = new Size(150, 43);
            input_barcode.TabIndex = 12;
            input_barcode.TextChanged += input_barcode_TextChanged_1;
            // 
            // button_next
            // 
            button_next.Location = new Point(1208, 687);
            button_next.Name = "button_next";
            button_next.Size = new Size(150, 50);
            button_next.TabIndex = 13;
            button_next.Text = "NEXT";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // price_output
            // 
            price_output.Font = new Font("Segoe UI", 50F);
            price_output.Location = new Point(15, 589);
            price_output.Name = "price_output";
            price_output.ReadOnly = true;
            price_output.Size = new Size(830, 96);
            price_output.TabIndex = 18;
            price_output.TextAlign = HorizontalAlignment.Center;
            price_output.TextChanged += price_output_TextChanged;
            // 
            // panel_special
            // 
            panel_special.BackColor = SystemColors.ButtonShadow;
            panel_special.Controls.Add(groupBox_special);
            panel_special.Location = new Point(851, 47);
            panel_special.Name = "panel_special";
            panel_special.Size = new Size(300, 530);
            panel_special.TabIndex = 19;
            // 
            // groupBox_special
            // 
            groupBox_special.Location = new Point(15, 15);
            groupBox_special.Name = "groupBox_special";
            groupBox_special.Size = new Size(270, 500);
            groupBox_special.TabIndex = 0;
            groupBox_special.TabStop = false;
            // 
            // button_sub
            // 
            button_sub.Font = new Font("Segoe UI", 25F);
            button_sub.Location = new Point(1208, 600);
            button_sub.Name = "button_sub";
            button_sub.Size = new Size(150, 50);
            button_sub.TabIndex = 20;
            button_sub.Text = "-";
            button_sub.UseVisualStyleBackColor = true;
            button_sub.Click += button_sub_Click;
            // 
            // button_add
            // 
            button_add.Font = new Font("Segoe UI", 25F);
            button_add.Location = new Point(1208, 550);
            button_add.Name = "button_add";
            button_add.Size = new Size(150, 50);
            button_add.TabIndex = 21;
            button_add.Text = "+";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(851, 33);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 23;
            label4.Text = "Special Products:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel_F2);
            Controls.Add(panel_add);
            Controls.Add(button_add);
            Controls.Add(button_sub);
            Controls.Add(panel_special);
            Controls.Add(price_output);
            Controls.Add(button_next);
            Controls.Add(input_barcode);
            Controls.Add(add_button);
            Controls.Add(panel_F1);
            Controls.Add(button_F2);
            Controls.Add(button_F1);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Form1";
            panel_F1.ResumeLayout(false);
            panel_F2.ResumeLayout(false);
            panel_add.ResumeLayout(false);
            panel_add.PerformLayout();
            panel_special.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_F2;
        private Button button_F1;
        private Panel panel_F1;
        private GroupBox groupBox_F1;
        private Button add_button;
        private TextBox input_barcode;
        private Button button_next;
        private Panel panel_add;
        private TextBox name_input;
        private Label label3;
        private TextBox price_input;
        private Label label2;
        private TextBox barcode_input;
        private Label label1;
        private Button button_done;
        private CheckBox special_check;
        private Button cancel_adding;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox price_output;
        private Panel panel_special;
        private GroupBox groupBox_special;
        private Button button_sub;
        private Button button_add;
        private Panel panel_F2;
        private GroupBox groupBox_F2;
        private Label label4;
    }
}
