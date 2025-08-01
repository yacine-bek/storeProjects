﻿namespace storeProjects
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
            groupBox_F1 = new BorderlessGroupBox();
            panel_F2 = new Panel();
            groupBox_F2 = new BorderlessGroupBox();
            panel_add = new Panel();
            label11 = new Label();
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
            groupBox_special = new BorderlessGroupBox();
            panel_editing = new Panel();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBox_editing_price = new TextBox();
            textBox_editing_name = new TextBox();
            label6 = new Label();
            textBox_editing_barcode = new TextBox();
            button_editing_confirm = new Button();
            button_sub = new Button();
            button_add = new Button();
            label4 = new Label();
            button_delete_element = new Button();
            button_edit_element = new Button();
            panel_delete = new Panel();
            label5 = new Label();
            textBox_barcode_delete = new TextBox();
            button_confirm_delete = new Button();
            button_multi = new Button();
            textBox_multi = new TextBox();
            label9 = new Label();
            panel_F1.SuspendLayout();
            panel_F2.SuspendLayout();
            panel_add.SuspendLayout();
            panel_special.SuspendLayout();
            panel_editing.SuspendLayout();
            panel_delete.SuspendLayout();
            SuspendLayout();
            // 
            // button_F2
            // 
            button_F2.BackColor = SystemColors.ControlLight;
            button_F2.FlatStyle = FlatStyle.Flat;
            button_F2.Location = new Point(121, 15);
            button_F2.Name = "button_F2";
            button_F2.Size = new Size(100, 35);
            button_F2.TabIndex = 7;
            button_F2.Text = "F2";
            button_F2.UseVisualStyleBackColor = false;
            button_F2.Click += button_F2_Click;
            // 
            // button_F1
            // 
            button_F1.BackColor = SystemColors.ControlDark;
            button_F1.FlatStyle = FlatStyle.Flat;
            button_F1.Location = new Point(18, 15);
            button_F1.Name = "button_F1";
            button_F1.Size = new Size(100, 35);
            button_F1.TabIndex = 6;
            button_F1.Text = "F1";
            button_F1.UseVisualStyleBackColor = false;
            button_F1.Click += button_F1_Click;
            // 
            // panel_F1
            // 
            panel_F1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            panel_F2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_F2.BackColor = SystemColors.ButtonShadow;
            panel_F2.Controls.Add(groupBox_F2);
            panel_F2.Location = new Point(15, 47);
            panel_F2.Name = "panel_F2";
            panel_F2.Size = new Size(830, 530);
            panel_F2.TabIndex = 22;
            // 
            // groupBox_F2
            // 
            groupBox_F2.FlatStyle = FlatStyle.Flat;
            groupBox_F2.Location = new Point(15, 15);
            groupBox_F2.Name = "groupBox_F2";
            groupBox_F2.Size = new Size(800, 500);
            groupBox_F2.TabIndex = 5;
            groupBox_F2.TabStop = false;
            // 
            // panel_add
            // 
            panel_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_add.BackColor = Color.Beige;
            panel_add.Controls.Add(label11);
            panel_add.Controls.Add(cancel_adding);
            panel_add.Controls.Add(special_check);
            panel_add.Controls.Add(name_input);
            panel_add.Controls.Add(label3);
            panel_add.Controls.Add(price_input);
            panel_add.Controls.Add(label2);
            panel_add.Controls.Add(barcode_input);
            panel_add.Controls.Add(label1);
            panel_add.Controls.Add(button_done);
            panel_add.Location = new Point(443, 219);
            panel_add.Name = "panel_add";
            panel_add.Size = new Size(500, 350);
            panel_add.TabIndex = 14;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Unispace", 25F);
            label11.Location = new Point(12, 12);
            label11.Name = "label11";
            label11.Size = new Size(312, 41);
            label11.TabIndex = 19;
            label11.Text = "ADD Product : ";
            // 
            // cancel_adding
            // 
            cancel_adding.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cancel_adding.Location = new Point(250, 285);
            cancel_adding.Name = "cancel_adding";
            cancel_adding.Size = new Size(150, 50);
            cancel_adding.TabIndex = 17;
            cancel_adding.Text = "Cancel";
            cancel_adding.UseVisualStyleBackColor = true;
            cancel_adding.Click += cancel_adding_Click;
            // 
            // special_check
            // 
            special_check.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            special_check.AutoSize = true;
            special_check.Font = new Font("Segoe UI", 15F);
            special_check.Location = new Point(301, 250);
            special_check.Name = "special_check";
            special_check.Size = new Size(99, 32);
            special_check.TabIndex = 7;
            special_check.Text = "special?";
            special_check.UseVisualStyleBackColor = true;
            special_check.CheckedChanged += special_check_CheckedChanged;
            special_check.KeyDown += special_check_KeyDown;
            // 
            // name_input
            // 
            name_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            name_input.Font = new Font("Segoe UI", 15F);
            name_input.Location = new Point(100, 151);
            name_input.Name = "name_input";
            name_input.Size = new Size(300, 34);
            name_input.TabIndex = 6;
            name_input.TextChanged += name_input_TextChanged;
            name_input.KeyDown += name_input_KeyDown;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(126, 120);
            label3.Name = "label3";
            label3.Size = new Size(255, 28);
            label3.TabIndex = 5;
            label3.Text = "Enter The name of Products:";
            // 
            // price_input
            // 
            price_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            price_input.Font = new Font("Segoe UI", 15F);
            price_input.Location = new Point(100, 215);
            price_input.Name = "price_input";
            price_input.Size = new Size(300, 34);
            price_input.TabIndex = 4;
            price_input.TextChanged += price_input_TextChanged;
            price_input.KeyDown += price_input_KeyDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(180, 184);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 3;
            label2.Text = "Enter The Price:";
            // 
            // barcode_input
            // 
            barcode_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            barcode_input.Font = new Font("Segoe UI", 15F);
            barcode_input.Location = new Point(100, 84);
            barcode_input.Name = "barcode_input";
            barcode_input.Size = new Size(300, 34);
            barcode_input.TabIndex = 2;
            barcode_input.TextChanged += barcode_input_TextChanged;
            barcode_input.KeyDown += barcode_input_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(180, 53);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 1;
            label1.Text = "Enter Bar Code:";
            // 
            // button_done
            // 
            button_done.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_done.Location = new Point(100, 285);
            button_done.Name = "button_done";
            button_done.Size = new Size(150, 50);
            button_done.TabIndex = 0;
            button_done.Text = "Done";
            button_done.UseVisualStyleBackColor = true;
            button_done.Click += button_done_Click;
            // 
            // add_button
            // 
            add_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            add_button.FlatStyle = FlatStyle.Flat;
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
            input_barcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            input_barcode.Font = new Font("Segoe UI", 20F);
            input_barcode.Location = new Point(1208, 71);
            input_barcode.Name = "input_barcode";
            input_barcode.Size = new Size(150, 43);
            input_barcode.TabIndex = 12;
            input_barcode.TextChanged += input_barcode_TextChanged_1;
            input_barcode.KeyDown += input_barcode_KeyDown;
            // 
            // button_next
            // 
            button_next.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_next.FlatStyle = FlatStyle.Flat;
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
            price_output.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            panel_special.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            // panel_editing
            // 
            panel_editing.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_editing.BackColor = Color.Cornsilk;
            panel_editing.Controls.Add(label10);
            panel_editing.Controls.Add(label8);
            panel_editing.Controls.Add(label7);
            panel_editing.Controls.Add(textBox_editing_price);
            panel_editing.Controls.Add(textBox_editing_name);
            panel_editing.Controls.Add(label6);
            panel_editing.Controls.Add(textBox_editing_barcode);
            panel_editing.Controls.Add(button_editing_confirm);
            panel_editing.Location = new Point(443, 219);
            panel_editing.Name = "panel_editing";
            panel_editing.Size = new Size(500, 350);
            panel_editing.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Unispace", 25F);
            label10.Location = new Point(38, 11);
            label10.Name = "label10";
            label10.Size = new Size(438, 41);
            label10.TabIndex = 8;
            label10.Text = "Edit Product Data : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(137, 220);
            label8.Name = "label8";
            label8.Size = new Size(229, 28);
            label8.TabIndex = 6;
            label8.Text = "New Price of the product";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(144, 152);
            label7.Name = "label7";
            label7.Size = new Size(205, 28);
            label7.TabIndex = 5;
            label7.Text = "New Name of Product";
            label7.Click += label7_Click;
            // 
            // textBox_editing_price
            // 
            textBox_editing_price.Font = new Font("Segoe UI", 15F);
            textBox_editing_price.Location = new Point(104, 255);
            textBox_editing_price.Name = "textBox_editing_price";
            textBox_editing_price.Size = new Size(300, 34);
            textBox_editing_price.TabIndex = 4;
            textBox_editing_price.TextChanged += textBox_editing_price_TextChanged;
            textBox_editing_price.KeyDown += textBox_editing_price_KeyDown;
            // 
            // textBox_editing_name
            // 
            textBox_editing_name.Font = new Font("Segoe UI", 15F);
            textBox_editing_name.Location = new Point(104, 183);
            textBox_editing_name.Name = "textBox_editing_name";
            textBox_editing_name.Size = new Size(300, 34);
            textBox_editing_name.TabIndex = 3;
            textBox_editing_name.KeyDown += textBox_editing_name_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(137, 55);
            label6.Name = "label6";
            label6.Size = new Size(231, 56);
            label6.TabIndex = 2;
            label6.Text = "Enter the code of \r\nthe element u wanna Edit";
            label6.TextAlign = ContentAlignment.BottomCenter;
            label6.Click += label6_Click;
            // 
            // textBox_editing_barcode
            // 
            textBox_editing_barcode.Font = new Font("Segoe UI", 15F);
            textBox_editing_barcode.Location = new Point(104, 114);
            textBox_editing_barcode.Name = "textBox_editing_barcode";
            textBox_editing_barcode.Size = new Size(300, 34);
            textBox_editing_barcode.TabIndex = 1;
            textBox_editing_barcode.KeyDown += textBox_editing_barcode_KeyDown;
            // 
            // button_editing_confirm
            // 
            button_editing_confirm.Font = new Font("Segoe UI", 14F);
            button_editing_confirm.Location = new Point(179, 295);
            button_editing_confirm.Name = "button_editing_confirm";
            button_editing_confirm.Size = new Size(150, 50);
            button_editing_confirm.TabIndex = 0;
            button_editing_confirm.Text = "Confirm";
            button_editing_confirm.UseVisualStyleBackColor = true;
            button_editing_confirm.Click += button1_Click;
            // 
            // button_sub
            // 
            button_sub.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.FlatStyle = FlatStyle.System;
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
            // button_delete_element
            // 
            button_delete_element.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_delete_element.Location = new Point(1283, 134);
            button_delete_element.Name = "button_delete_element";
            button_delete_element.Size = new Size(75, 50);
            button_delete_element.TabIndex = 24;
            button_delete_element.Text = "delete";
            button_delete_element.UseVisualStyleBackColor = true;
            button_delete_element.Click += button_delete_element_Click;
            // 
            // button_edit_element
            // 
            button_edit_element.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_edit_element.Location = new Point(1208, 134);
            button_edit_element.Name = "button_edit_element";
            button_edit_element.Size = new Size(75, 50);
            button_edit_element.TabIndex = 25;
            button_edit_element.Text = "Edit";
            button_edit_element.UseVisualStyleBackColor = true;
            button_edit_element.Click += button_edit_element_Click;
            // 
            // panel_delete
            // 
            panel_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_delete.BackColor = SystemColors.ButtonShadow;
            panel_delete.Controls.Add(label5);
            panel_delete.Controls.Add(textBox_barcode_delete);
            panel_delete.Controls.Add(button_confirm_delete);
            panel_delete.Location = new Point(1158, 183);
            panel_delete.Name = "panel_delete";
            panel_delete.Size = new Size(200, 128);
            panel_delete.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 10);
            label5.Name = "label5";
            label5.Size = new Size(153, 30);
            label5.TabIndex = 2;
            label5.Text = "Enter the code of \r\nthe element u wanna delete";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBox_barcode_delete
            // 
            textBox_barcode_delete.Location = new Point(3, 52);
            textBox_barcode_delete.Name = "textBox_barcode_delete";
            textBox_barcode_delete.Size = new Size(194, 23);
            textBox_barcode_delete.TabIndex = 1;
            textBox_barcode_delete.KeyDown += textBox_barcode_delete_KeyDown;
            // 
            // button_confirm_delete
            // 
            button_confirm_delete.Location = new Point(50, 84);
            button_confirm_delete.Name = "button_confirm_delete";
            button_confirm_delete.Size = new Size(100, 40);
            button_confirm_delete.TabIndex = 0;
            button_confirm_delete.Text = "Confirm";
            button_confirm_delete.UseVisualStyleBackColor = true;
            button_confirm_delete.Click += button_confirm_delete_Click;
            // 
            // button_multi
            // 
            button_multi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_multi.FlatStyle = FlatStyle.System;
            button_multi.Font = new Font("Segoe UI", 25F);
            button_multi.Location = new Point(1205, 417);
            button_multi.Name = "button_multi";
            button_multi.Size = new Size(150, 50);
            button_multi.TabIndex = 28;
            button_multi.Text = "*";
            button_multi.UseVisualStyleBackColor = true;
            button_multi.Click += button_multi_Click;
            // 
            // textBox_multi
            // 
            textBox_multi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox_multi.Font = new Font("Segoe UI", 20F);
            textBox_multi.Location = new Point(1205, 469);
            textBox_multi.Name = "textBox_multi";
            textBox_multi.Size = new Size(150, 43);
            textBox_multi.TabIndex = 29;
            textBox_multi.TextAlign = HorizontalAlignment.Center;
            textBox_multi.Visible = false;
            textBox_multi.TextChanged += textBox_multi_TextChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(1205, 403);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 30;
            label9.Text = "+10 only :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel_add);
            Controls.Add(label9);
            Controls.Add(textBox_multi);
            Controls.Add(button_multi);
            Controls.Add(panel_editing);
            Controls.Add(panel_delete);
            Controls.Add(button_edit_element);
            Controls.Add(button_delete_element);
            Controls.Add(panel_F2);
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
            panel_editing.ResumeLayout(false);
            panel_editing.PerformLayout();
            panel_delete.ResumeLayout(false);
            panel_delete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_F2;
        private Button button_F1;
        private Panel panel_F1;
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
        private Button button_sub;
        private Button button_add;
        private Panel panel_F2;
        private Label label4;
        private Button button_delete_element;
        private Button button_edit_element;
        private Panel panel_delete;
        private Label label5;
        private TextBox textBox_barcode_delete;
        private Button button_confirm_delete;
        private Panel panel_editing;
        private Label label8;
        private Label label7;
        private TextBox textBox_editing_price;
        private TextBox textBox_editing_name;
        private Label label6;
        private TextBox textBox_editing_barcode;
        private Button button_editing_confirm;
        private BorderlessGroupBox groupBox_F1;
        private BorderlessGroupBox groupBox_special;
        private BorderlessGroupBox groupBox_F2;
        private Label label11;
        private Label label10;
        private Button button_multi;
        private TextBox textBox_multi;
        private Label label9;
    }
}
