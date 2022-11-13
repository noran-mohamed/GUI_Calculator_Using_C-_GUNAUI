namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnexit = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lbl = new Guna.UI.WinForms.GunaLabel();
            this.btnmulti = new Guna.UI.WinForms.GunaButton();
            this.btndivide = new Guna.UI.WinForms.GunaButton();
            this.btnplus = new Guna.UI.WinForms.GunaButton();
            this.btnmin = new Guna.UI.WinForms.GunaButton();
            this.btnsix = new Guna.UI.WinForms.GunaButton();
            this.btnthree = new Guna.UI.WinForms.GunaButton();
            this.btnrd = new Guna.UI.WinForms.GunaButton();
            this.btnnine = new Guna.UI.WinForms.GunaButton();
            this.btnfour = new Guna.UI.WinForms.GunaButton();
            this.btnone = new Guna.UI.WinForms.GunaButton();
            this.btnclear = new Guna.UI.WinForms.GunaButton();
            this.btnseven = new Guna.UI.WinForms.GunaButton();
            this.btnfive = new Guna.UI.WinForms.GunaButton();
            this.btntwo = new Guna.UI.WinForms.GunaButton();
            this.btneight = new Guna.UI.WinForms.GunaButton();
            this.btnzero = new Guna.UI.WinForms.GunaButton();
            this.btndot = new Guna.UI.WinForms.GunaButton();
            this.btnequal = new Guna.UI.WinForms.GunaButton();
            this.txtstore = new Guna.UI.WinForms.GunaTextBox();
            this.txtresult = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BaseColor = System.Drawing.Color.White;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(275, -1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(48, 42);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnexit.TabIndex = 0;
            this.btnexit.TabStop = false;
            this.btnexit.UseTransfarantBackground = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Forte", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(2, 4);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(172, 36);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Calculator";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.AnimationHoverSpeed = 0.07F;
            this.btnmulti.AnimationSpeed = 0.03F;
            this.btnmulti.BackColor = System.Drawing.Color.Transparent;
            this.btnmulti.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnmulti.BorderColor = System.Drawing.Color.Black;
            this.btnmulti.BorderSize = 2;
            this.btnmulti.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnmulti.FocusedColor = System.Drawing.Color.Empty;
            this.btnmulti.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnmulti.ForeColor = System.Drawing.Color.Black;
            this.btnmulti.Image = null;
            this.btnmulti.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnmulti.ImageSize = new System.Drawing.Size(20, 20);
            this.btnmulti.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnmulti.Location = new System.Drawing.Point(230, 307);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnmulti.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnmulti.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnmulti.OnHoverImage = null;
            this.btnmulti.OnPressedColor = System.Drawing.Color.Black;
            this.btnmulti.Radius = 15;
            this.btnmulti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnmulti.Size = new System.Drawing.Size(60, 42);
            this.btnmulti.TabIndex = 14;
            this.btnmulti.Text = "x";
            this.btnmulti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnmulti.UseTransfarantBackground = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btndivide
            // 
            this.btndivide.AnimationHoverSpeed = 0.07F;
            this.btndivide.AnimationSpeed = 0.03F;
            this.btndivide.BackColor = System.Drawing.Color.Transparent;
            this.btndivide.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btndivide.BorderColor = System.Drawing.Color.Black;
            this.btndivide.BorderSize = 2;
            this.btndivide.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btndivide.FocusedColor = System.Drawing.Color.Empty;
            this.btndivide.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btndivide.ForeColor = System.Drawing.Color.Black;
            this.btndivide.Image = null;
            this.btndivide.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btndivide.ImageSize = new System.Drawing.Size(20, 20);
            this.btndivide.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btndivide.Location = new System.Drawing.Point(228, 259);
            this.btndivide.Name = "btndivide";
            this.btndivide.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btndivide.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndivide.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btndivide.OnHoverImage = null;
            this.btndivide.OnPressedColor = System.Drawing.Color.Black;
            this.btndivide.Radius = 15;
            this.btndivide.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btndivide.Size = new System.Drawing.Size(60, 42);
            this.btndivide.TabIndex = 15;
            this.btndivide.Text = "/";
            this.btndivide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btndivide.UseTransfarantBackground = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnplus
            // 
            this.btnplus.AnimationHoverSpeed = 0.07F;
            this.btnplus.AnimationSpeed = 0.03F;
            this.btnplus.BackColor = System.Drawing.Color.Transparent;
            this.btnplus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnplus.BorderColor = System.Drawing.Color.Black;
            this.btnplus.BorderSize = 2;
            this.btnplus.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnplus.FocusedColor = System.Drawing.Color.Empty;
            this.btnplus.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnplus.ForeColor = System.Drawing.Color.Black;
            this.btnplus.Image = null;
            this.btnplus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnplus.ImageSize = new System.Drawing.Size(20, 20);
            this.btnplus.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnplus.Location = new System.Drawing.Point(230, 355);
            this.btnplus.Name = "btnplus";
            this.btnplus.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnplus.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnplus.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnplus.OnHoverImage = null;
            this.btnplus.OnPressedColor = System.Drawing.Color.Black;
            this.btnplus.Radius = 15;
            this.btnplus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnplus.Size = new System.Drawing.Size(60, 42);
            this.btnplus.TabIndex = 17;
            this.btnplus.Text = "+";
            this.btnplus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnplus.UseTransfarantBackground = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnmin
            // 
            this.btnmin.AnimationHoverSpeed = 0.07F;
            this.btnmin.AnimationSpeed = 0.03F;
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnmin.BorderColor = System.Drawing.Color.Black;
            this.btnmin.BorderSize = 2;
            this.btnmin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnmin.FocusedColor = System.Drawing.Color.Empty;
            this.btnmin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnmin.ForeColor = System.Drawing.Color.Black;
            this.btnmin.Image = null;
            this.btnmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnmin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnmin.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnmin.Location = new System.Drawing.Point(229, 403);
            this.btnmin.Name = "btnmin";
            this.btnmin.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnmin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnmin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnmin.OnHoverImage = null;
            this.btnmin.OnPressedColor = System.Drawing.Color.Black;
            this.btnmin.Radius = 15;
            this.btnmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnmin.Size = new System.Drawing.Size(60, 42);
            this.btnmin.TabIndex = 16;
            this.btnmin.Text = "-";
            this.btnmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnmin.UseTransfarantBackground = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnsix
            // 
            this.btnsix.AnimationHoverSpeed = 0.07F;
            this.btnsix.AnimationSpeed = 0.03F;
            this.btnsix.BackColor = System.Drawing.Color.Transparent;
            this.btnsix.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnsix.BorderColor = System.Drawing.Color.Black;
            this.btnsix.BorderSize = 2;
            this.btnsix.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnsix.FocusedColor = System.Drawing.Color.Empty;
            this.btnsix.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnsix.ForeColor = System.Drawing.Color.Black;
            this.btnsix.Image = null;
            this.btnsix.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsix.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsix.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnsix.Location = new System.Drawing.Point(164, 355);
            this.btnsix.Name = "btnsix";
            this.btnsix.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnsix.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsix.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnsix.OnHoverImage = null;
            this.btnsix.OnPressedColor = System.Drawing.Color.Black;
            this.btnsix.Radius = 15;
            this.btnsix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsix.Size = new System.Drawing.Size(60, 42);
            this.btnsix.TabIndex = 21;
            this.btnsix.Text = "6";
            this.btnsix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsix.UseTransfarantBackground = true;
            this.btnsix.Click += new System.EventHandler(this.btnsix_Click);
            // 
            // btnthree
            // 
            this.btnthree.AnimationHoverSpeed = 0.07F;
            this.btnthree.AnimationSpeed = 0.03F;
            this.btnthree.BackColor = System.Drawing.Color.Transparent;
            this.btnthree.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnthree.BorderColor = System.Drawing.Color.Black;
            this.btnthree.BorderSize = 2;
            this.btnthree.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnthree.FocusedColor = System.Drawing.Color.Empty;
            this.btnthree.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnthree.ForeColor = System.Drawing.Color.Black;
            this.btnthree.Image = null;
            this.btnthree.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnthree.ImageSize = new System.Drawing.Size(20, 20);
            this.btnthree.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnthree.Location = new System.Drawing.Point(162, 403);
            this.btnthree.Name = "btnthree";
            this.btnthree.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnthree.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnthree.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnthree.OnHoverImage = null;
            this.btnthree.OnPressedColor = System.Drawing.Color.Black;
            this.btnthree.Radius = 15;
            this.btnthree.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnthree.Size = new System.Drawing.Size(60, 42);
            this.btnthree.TabIndex = 20;
            this.btnthree.Text = "3";
            this.btnthree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnthree.UseTransfarantBackground = true;
            this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // btnrd
            // 
            this.btnrd.AnimationHoverSpeed = 0.07F;
            this.btnrd.AnimationSpeed = 0.03F;
            this.btnrd.BackColor = System.Drawing.Color.Transparent;
            this.btnrd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnrd.BorderColor = System.Drawing.Color.Black;
            this.btnrd.BorderSize = 2;
            this.btnrd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnrd.FocusedColor = System.Drawing.Color.Empty;
            this.btnrd.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnrd.ForeColor = System.Drawing.Color.Black;
            this.btnrd.Image = null;
            this.btnrd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnrd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnrd.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnrd.Location = new System.Drawing.Point(163, 259);
            this.btnrd.Name = "btnrd";
            this.btnrd.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnrd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnrd.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnrd.OnHoverImage = null;
            this.btnrd.OnPressedColor = System.Drawing.Color.Black;
            this.btnrd.Radius = 15;
            this.btnrd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnrd.Size = new System.Drawing.Size(60, 42);
            this.btnrd.TabIndex = 19;
            this.btnrd.Text = "%";
            this.btnrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnrd.UseTransfarantBackground = true;
            this.btnrd.Click += new System.EventHandler(this.btnrd_Click);
            // 
            // btnnine
            // 
            this.btnnine.AnimationHoverSpeed = 0.07F;
            this.btnnine.AnimationSpeed = 0.03F;
            this.btnnine.BackColor = System.Drawing.Color.Transparent;
            this.btnnine.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnnine.BorderColor = System.Drawing.Color.Black;
            this.btnnine.BorderSize = 2;
            this.btnnine.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnnine.FocusedColor = System.Drawing.Color.Empty;
            this.btnnine.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnnine.ForeColor = System.Drawing.Color.Black;
            this.btnnine.Image = null;
            this.btnnine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnnine.ImageSize = new System.Drawing.Size(20, 20);
            this.btnnine.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnnine.Location = new System.Drawing.Point(164, 307);
            this.btnnine.Name = "btnnine";
            this.btnnine.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnnine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnnine.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnnine.OnHoverImage = null;
            this.btnnine.OnPressedColor = System.Drawing.Color.Black;
            this.btnnine.Radius = 15;
            this.btnnine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnnine.Size = new System.Drawing.Size(60, 42);
            this.btnnine.TabIndex = 18;
            this.btnnine.Text = "9";
            this.btnnine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnnine.UseTransfarantBackground = true;
            this.btnnine.Click += new System.EventHandler(this.btnnine_Click);
            // 
            // btnfour
            // 
            this.btnfour.AnimationHoverSpeed = 0.07F;
            this.btnfour.AnimationSpeed = 0.03F;
            this.btnfour.BackColor = System.Drawing.Color.Transparent;
            this.btnfour.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnfour.BorderColor = System.Drawing.Color.Black;
            this.btnfour.BorderSize = 2;
            this.btnfour.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnfour.FocusedColor = System.Drawing.Color.Empty;
            this.btnfour.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnfour.ForeColor = System.Drawing.Color.Black;
            this.btnfour.Image = null;
            this.btnfour.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnfour.ImageSize = new System.Drawing.Size(20, 20);
            this.btnfour.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnfour.Location = new System.Drawing.Point(32, 355);
            this.btnfour.Name = "btnfour";
            this.btnfour.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnfour.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnfour.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnfour.OnHoverImage = null;
            this.btnfour.OnPressedColor = System.Drawing.Color.Black;
            this.btnfour.Radius = 15;
            this.btnfour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnfour.Size = new System.Drawing.Size(60, 42);
            this.btnfour.TabIndex = 29;
            this.btnfour.Text = "4";
            this.btnfour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnfour.UseTransfarantBackground = true;
            this.btnfour.Click += new System.EventHandler(this.btnfour_Click);
            // 
            // btnone
            // 
            this.btnone.AnimationHoverSpeed = 0.07F;
            this.btnone.AnimationSpeed = 0.03F;
            this.btnone.BackColor = System.Drawing.Color.Transparent;
            this.btnone.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnone.BorderColor = System.Drawing.Color.Black;
            this.btnone.BorderSize = 2;
            this.btnone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnone.FocusedColor = System.Drawing.Color.Empty;
            this.btnone.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnone.ForeColor = System.Drawing.Color.Black;
            this.btnone.Image = null;
            this.btnone.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnone.ImageSize = new System.Drawing.Size(20, 20);
            this.btnone.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnone.Location = new System.Drawing.Point(32, 403);
            this.btnone.Name = "btnone";
            this.btnone.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnone.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnone.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnone.OnHoverImage = null;
            this.btnone.OnPressedColor = System.Drawing.Color.Black;
            this.btnone.Radius = 15;
            this.btnone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnone.Size = new System.Drawing.Size(60, 42);
            this.btnone.TabIndex = 28;
            this.btnone.Text = "1";
            this.btnone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnone.UseTransfarantBackground = true;
            this.btnone.Click += new System.EventHandler(this.btnone_Click);
            // 
            // btnclear
            // 
            this.btnclear.AnimationHoverSpeed = 0.07F;
            this.btnclear.AnimationSpeed = 0.03F;
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnclear.BorderColor = System.Drawing.Color.Black;
            this.btnclear.BorderSize = 2;
            this.btnclear.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnclear.FocusedColor = System.Drawing.Color.Empty;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Image = null;
            this.btnclear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnclear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnclear.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnclear.Location = new System.Drawing.Point(32, 259);
            this.btnclear.Name = "btnclear";
            this.btnclear.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnclear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnclear.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnclear.OnHoverImage = null;
            this.btnclear.OnPressedColor = System.Drawing.Color.Black;
            this.btnclear.Radius = 15;
            this.btnclear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnclear.Size = new System.Drawing.Size(125, 42);
            this.btnclear.TabIndex = 27;
            this.btnclear.Text = "C";
            this.btnclear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnclear.UseTransfarantBackground = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnseven
            // 
            this.btnseven.AnimationHoverSpeed = 0.07F;
            this.btnseven.AnimationSpeed = 0.03F;
            this.btnseven.BackColor = System.Drawing.Color.Transparent;
            this.btnseven.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnseven.BorderColor = System.Drawing.Color.Black;
            this.btnseven.BorderSize = 2;
            this.btnseven.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnseven.FocusedColor = System.Drawing.Color.Empty;
            this.btnseven.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnseven.ForeColor = System.Drawing.Color.Black;
            this.btnseven.Image = null;
            this.btnseven.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnseven.ImageSize = new System.Drawing.Size(20, 20);
            this.btnseven.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnseven.Location = new System.Drawing.Point(32, 307);
            this.btnseven.Name = "btnseven";
            this.btnseven.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnseven.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnseven.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnseven.OnHoverImage = null;
            this.btnseven.OnPressedColor = System.Drawing.Color.Black;
            this.btnseven.Radius = 15;
            this.btnseven.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnseven.Size = new System.Drawing.Size(60, 42);
            this.btnseven.TabIndex = 26;
            this.btnseven.Text = "7";
            this.btnseven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnseven.UseTransfarantBackground = true;
            this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
            // 
            // btnfive
            // 
            this.btnfive.AnimationHoverSpeed = 0.07F;
            this.btnfive.AnimationSpeed = 0.03F;
            this.btnfive.BackColor = System.Drawing.Color.Transparent;
            this.btnfive.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnfive.BorderColor = System.Drawing.Color.Black;
            this.btnfive.BorderSize = 2;
            this.btnfive.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnfive.FocusedColor = System.Drawing.Color.Empty;
            this.btnfive.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnfive.ForeColor = System.Drawing.Color.Black;
            this.btnfive.Image = null;
            this.btnfive.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnfive.ImageSize = new System.Drawing.Size(20, 20);
            this.btnfive.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnfive.Location = new System.Drawing.Point(98, 355);
            this.btnfive.Name = "btnfive";
            this.btnfive.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnfive.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnfive.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnfive.OnHoverImage = null;
            this.btnfive.OnPressedColor = System.Drawing.Color.Black;
            this.btnfive.Radius = 15;
            this.btnfive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnfive.Size = new System.Drawing.Size(60, 42);
            this.btnfive.TabIndex = 25;
            this.btnfive.Text = "5";
            this.btnfive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnfive.UseTransfarantBackground = true;
            this.btnfive.Click += new System.EventHandler(this.btnfive_Click);
            // 
            // btntwo
            // 
            this.btntwo.AnimationHoverSpeed = 0.07F;
            this.btntwo.AnimationSpeed = 0.03F;
            this.btntwo.BackColor = System.Drawing.Color.Transparent;
            this.btntwo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btntwo.BorderColor = System.Drawing.Color.Black;
            this.btntwo.BorderSize = 2;
            this.btntwo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btntwo.FocusedColor = System.Drawing.Color.Empty;
            this.btntwo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btntwo.ForeColor = System.Drawing.Color.Black;
            this.btntwo.Image = null;
            this.btntwo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btntwo.ImageSize = new System.Drawing.Size(20, 20);
            this.btntwo.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btntwo.Location = new System.Drawing.Point(98, 403);
            this.btntwo.Name = "btntwo";
            this.btntwo.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btntwo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btntwo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btntwo.OnHoverImage = null;
            this.btntwo.OnPressedColor = System.Drawing.Color.Black;
            this.btntwo.Radius = 15;
            this.btntwo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btntwo.Size = new System.Drawing.Size(60, 42);
            this.btntwo.TabIndex = 24;
            this.btntwo.Text = "2";
            this.btntwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btntwo.UseTransfarantBackground = true;
            this.btntwo.Click += new System.EventHandler(this.btntwo_Click);
            // 
            // btneight
            // 
            this.btneight.AnimationHoverSpeed = 0.07F;
            this.btneight.AnimationSpeed = 0.03F;
            this.btneight.BackColor = System.Drawing.Color.Transparent;
            this.btneight.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btneight.BorderColor = System.Drawing.Color.Black;
            this.btneight.BorderSize = 2;
            this.btneight.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btneight.FocusedColor = System.Drawing.Color.Empty;
            this.btneight.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btneight.ForeColor = System.Drawing.Color.Black;
            this.btneight.Image = null;
            this.btneight.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btneight.ImageSize = new System.Drawing.Size(20, 20);
            this.btneight.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btneight.Location = new System.Drawing.Point(98, 307);
            this.btneight.Name = "btneight";
            this.btneight.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btneight.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btneight.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btneight.OnHoverImage = null;
            this.btneight.OnPressedColor = System.Drawing.Color.Black;
            this.btneight.Radius = 15;
            this.btneight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btneight.Size = new System.Drawing.Size(60, 42);
            this.btneight.TabIndex = 22;
            this.btneight.Text = "8";
            this.btneight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btneight.UseTransfarantBackground = true;
            this.btneight.Click += new System.EventHandler(this.btneight_Click);
            // 
            // btnzero
            // 
            this.btnzero.AnimationHoverSpeed = 0.07F;
            this.btnzero.AnimationSpeed = 0.03F;
            this.btnzero.BackColor = System.Drawing.Color.Transparent;
            this.btnzero.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnzero.BorderColor = System.Drawing.Color.Black;
            this.btnzero.BorderSize = 2;
            this.btnzero.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnzero.FocusedColor = System.Drawing.Color.Empty;
            this.btnzero.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnzero.ForeColor = System.Drawing.Color.Black;
            this.btnzero.Image = null;
            this.btnzero.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnzero.ImageSize = new System.Drawing.Size(20, 20);
            this.btnzero.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnzero.Location = new System.Drawing.Point(32, 451);
            this.btnzero.Name = "btnzero";
            this.btnzero.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnzero.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnzero.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnzero.OnHoverImage = null;
            this.btnzero.OnPressedColor = System.Drawing.Color.Black;
            this.btnzero.Radius = 15;
            this.btnzero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnzero.Size = new System.Drawing.Size(60, 42);
            this.btnzero.TabIndex = 32;
            this.btnzero.Text = "0";
            this.btnzero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnzero.UseTransfarantBackground = true;
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btndot
            // 
            this.btndot.AnimationHoverSpeed = 0.07F;
            this.btndot.AnimationSpeed = 0.03F;
            this.btndot.BackColor = System.Drawing.Color.Transparent;
            this.btndot.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btndot.BorderColor = System.Drawing.Color.Black;
            this.btndot.BorderSize = 2;
            this.btndot.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btndot.FocusedColor = System.Drawing.Color.Empty;
            this.btndot.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btndot.ForeColor = System.Drawing.Color.Black;
            this.btndot.Image = null;
            this.btndot.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btndot.ImageSize = new System.Drawing.Size(20, 20);
            this.btndot.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btndot.Location = new System.Drawing.Point(98, 451);
            this.btndot.Name = "btndot";
            this.btndot.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btndot.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndot.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btndot.OnHoverImage = null;
            this.btndot.OnPressedColor = System.Drawing.Color.Black;
            this.btndot.Radius = 15;
            this.btndot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btndot.Size = new System.Drawing.Size(60, 42);
            this.btndot.TabIndex = 31;
            this.btndot.Text = ".";
            this.btndot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btndot.UseTransfarantBackground = true;
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btnequal
            // 
            this.btnequal.AnimationHoverSpeed = 0.07F;
            this.btnequal.AnimationSpeed = 0.03F;
            this.btnequal.BackColor = System.Drawing.Color.Transparent;
            this.btnequal.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnequal.BorderColor = System.Drawing.Color.Black;
            this.btnequal.BorderSize = 2;
            this.btnequal.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnequal.FocusedColor = System.Drawing.Color.Empty;
            this.btnequal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnequal.ForeColor = System.Drawing.Color.Black;
            this.btnequal.Image = null;
            this.btnequal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnequal.ImageSize = new System.Drawing.Size(20, 20);
            this.btnequal.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnequal.Location = new System.Drawing.Point(164, 451);
            this.btnequal.Name = "btnequal";
            this.btnequal.OnHoverBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.btnequal.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnequal.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnequal.OnHoverImage = null;
            this.btnequal.OnPressedColor = System.Drawing.Color.Black;
            this.btnequal.Radius = 15;
            this.btnequal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnequal.Size = new System.Drawing.Size(125, 42);
            this.btnequal.TabIndex = 30;
            this.btnequal.Text = "=";
            this.btnequal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnequal.UseTransfarantBackground = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // txtstore
            // 
            this.txtstore.BackColor = System.Drawing.Color.Transparent;
            this.txtstore.BaseColor = System.Drawing.Color.BlanchedAlmond;
            this.txtstore.BorderColor = System.Drawing.Color.Silver;
            this.txtstore.BorderSize = 0;
            this.txtstore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstore.FocusedBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.txtstore.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtstore.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtstore.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtstore.Location = new System.Drawing.Point(32, 161);
            this.txtstore.Name = "txtstore";
            this.txtstore.PasswordChar = '\0';
            this.txtstore.Radius = 15;
            this.txtstore.ReadOnly = true;
            this.txtstore.SelectedText = "";
            this.txtstore.Size = new System.Drawing.Size(256, 70);
            this.txtstore.TabIndex = 33;
            // 
            // txtresult
            // 
            this.txtresult.BackColor = System.Drawing.Color.Transparent;
            this.txtresult.BaseColor = System.Drawing.Color.BlanchedAlmond;
            this.txtresult.BorderColor = System.Drawing.Color.Silver;
            this.txtresult.BorderSize = 0;
            this.txtresult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtresult.FocusedBaseColor = System.Drawing.Color.BlanchedAlmond;
            this.txtresult.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtresult.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtresult.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtresult.Location = new System.Drawing.Point(32, 68);
            this.txtresult.Name = "txtresult";
            this.txtresult.PasswordChar = '\0';
            this.txtresult.Radius = 15;
            this.txtresult.ReadOnly = true;
            this.txtresult.SelectedText = "";
            this.txtresult.Size = new System.Drawing.Size(256, 67);
            this.txtresult.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(323, 530);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtstore);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnfour);
            this.Controls.Add(this.btnone);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnseven);
            this.Controls.Add(this.btnfive);
            this.Controls.Add(this.btntwo);
            this.Controls.Add(this.btneight);
            this.Controls.Add(this.btnsix);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btnrd);
            this.Controls.Add(this.btnnine);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox btnexit;
        private Guna.UI.WinForms.GunaLabel lbl;
        private Guna.UI.WinForms.GunaButton btnmulti;
        private Guna.UI.WinForms.GunaButton btndivide;
        private Guna.UI.WinForms.GunaButton btnplus;
        private Guna.UI.WinForms.GunaButton btnmin;
        private Guna.UI.WinForms.GunaButton btnsix;
        private Guna.UI.WinForms.GunaButton btnthree;
        private Guna.UI.WinForms.GunaButton btnrd;
        private Guna.UI.WinForms.GunaButton btnnine;
        private Guna.UI.WinForms.GunaButton btnfour;
        private Guna.UI.WinForms.GunaButton btnone;
        private Guna.UI.WinForms.GunaButton btnclear;
        private Guna.UI.WinForms.GunaButton btnseven;
        private Guna.UI.WinForms.GunaButton btnfive;
        private Guna.UI.WinForms.GunaButton btntwo;
        private Guna.UI.WinForms.GunaButton btneight;
        private Guna.UI.WinForms.GunaButton btnzero;
        private Guna.UI.WinForms.GunaButton btndot;
        private Guna.UI.WinForms.GunaButton btnequal;
        private Guna.UI.WinForms.GunaTextBox txtstore;
        private Guna.UI.WinForms.GunaTextBox txtresult;
    }
}

