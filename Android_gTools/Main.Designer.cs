namespace Android_gTools
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StandardJava = new System.Windows.Forms.TabPage();
            this.cbx_java_isUpper = new System.Windows.Forms.CheckBox();
            this.btn_java_init = new System.Windows.Forms.Button();
            this.btn_java_ViewInject = new System.Windows.Forms.Button();
            this.btn_java_Annotations = new System.Windows.Forms.Button();
            this.btn_java_ok = new System.Windows.Forms.Button();
            this.tbx_java_suffix = new System.Windows.Forms.TextBox();
            this.tbx_java_prefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_java_final = new System.Windows.Forms.RadioButton();
            this.rb_java_static = new System.Windows.Forms.RadioButton();
            this.rb_java_private = new System.Windows.Forms.RadioButton();
            this.rb_java_public = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Style = new System.Windows.Forms.TabPage();
            this.btn_style_ok = new System.Windows.Forms.Button();
            this.tbx_style_item_value = new System.Windows.Forms.TextBox();
            this.tbx_style_name = new System.Windows.Forms.TextBox();
            this.tbx_style_item_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_style_init = new System.Windows.Forms.Button();
            this.ViewHolder = new System.Windows.Forms.TabPage();
            this.cbx_viewholder_isUpper = new System.Windows.Forms.CheckBox();
            this.cbx_listview = new System.Windows.Forms.CheckBox();
            this.btn_viewHolder_init = new System.Windows.Forms.Button();
            this.btn_viewHolder_ok = new System.Windows.Forms.Button();
            this.tbx_viewholder_suffix = new System.Windows.Forms.TextBox();
            this.tbx_viewholder_prefix = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rb_viewholder_final = new System.Windows.Forms.RadioButton();
            this.rb_viewholder_static = new System.Windows.Forms.RadioButton();
            this.rb_viewholder_private = new System.Windows.Forms.RadioButton();
            this.rb_viewholder_public = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.Json = new System.Windows.Forms.TabPage();
            this.btn_json_init = new System.Windows.Forms.Button();
            this.tbx_json_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_json_ok = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tv_xml = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.StandardJava.SuspendLayout();
            this.Style.SuspendLayout();
            this.ViewHolder.SuspendLayout();
            this.Json.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1131, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripButton1.Size = new System.Drawing.Size(70, 31);
            this.toolStripButton1.Text = "关于作者";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 414);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StandardJava);
            this.tabControl1.Controls.Add(this.Style);
            this.tabControl1.Controls.Add(this.ViewHolder);
            this.tabControl1.Controls.Add(this.Json);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1131, 119);
            this.tabControl1.TabIndex = 4;
            // 
            // StandardJava
            // 
            this.StandardJava.Controls.Add(this.cbx_java_isUpper);
            this.StandardJava.Controls.Add(this.btn_java_init);
            this.StandardJava.Controls.Add(this.btn_java_ViewInject);
            this.StandardJava.Controls.Add(this.btn_java_Annotations);
            this.StandardJava.Controls.Add(this.btn_java_ok);
            this.StandardJava.Controls.Add(this.tbx_java_suffix);
            this.StandardJava.Controls.Add(this.tbx_java_prefix);
            this.StandardJava.Controls.Add(this.label4);
            this.StandardJava.Controls.Add(this.label3);
            this.StandardJava.Controls.Add(this.rb_java_final);
            this.StandardJava.Controls.Add(this.rb_java_static);
            this.StandardJava.Controls.Add(this.rb_java_private);
            this.StandardJava.Controls.Add(this.rb_java_public);
            this.StandardJava.Controls.Add(this.label2);
            this.StandardJava.Location = new System.Drawing.Point(4, 22);
            this.StandardJava.Name = "StandardJava";
            this.StandardJava.Padding = new System.Windows.Forms.Padding(3);
            this.StandardJava.Size = new System.Drawing.Size(1123, 93);
            this.StandardJava.TabIndex = 0;
            this.StandardJava.Text = "StandardJava";
            this.StandardJava.UseVisualStyleBackColor = true;
            // 
            // cbx_java_isUpper
            // 
            this.cbx_java_isUpper.AutoSize = true;
            this.cbx_java_isUpper.Location = new System.Drawing.Point(198, 74);
            this.cbx_java_isUpper.Name = "cbx_java_isUpper";
            this.cbx_java_isUpper.Size = new System.Drawing.Size(84, 16);
            this.cbx_java_isUpper.TabIndex = 30;
            this.cbx_java_isUpper.Text = "首字符大写";
            this.cbx_java_isUpper.UseVisualStyleBackColor = true;
            // 
            // btn_java_init
            // 
            this.btn_java_init.Location = new System.Drawing.Point(25, 21);
            this.btn_java_init.Name = "btn_java_init";
            this.btn_java_init.Size = new System.Drawing.Size(75, 23);
            this.btn_java_init.TabIndex = 28;
            this.btn_java_init.Text = "初始化";
            this.btn_java_init.UseVisualStyleBackColor = true;
            this.btn_java_init.Click += new System.EventHandler(this.btn_java_init_Click);
            // 
            // btn_java_ViewInject
            // 
            this.btn_java_ViewInject.Location = new System.Drawing.Point(737, 64);
            this.btn_java_ViewInject.Name = "btn_java_ViewInject";
            this.btn_java_ViewInject.Size = new System.Drawing.Size(112, 23);
            this.btn_java_ViewInject.TabIndex = 28;
            this.btn_java_ViewInject.Text = "生成ViewInject";
            this.btn_java_ViewInject.UseVisualStyleBackColor = true;
            this.btn_java_ViewInject.Click += new System.EventHandler(this.btn_java_ViewInject_Click);
            // 
            // btn_java_Annotations
            // 
            this.btn_java_Annotations.Location = new System.Drawing.Point(619, 64);
            this.btn_java_Annotations.Name = "btn_java_Annotations";
            this.btn_java_Annotations.Size = new System.Drawing.Size(112, 23);
            this.btn_java_Annotations.TabIndex = 28;
            this.btn_java_Annotations.Text = "生成Annotations";
            this.btn_java_Annotations.UseVisualStyleBackColor = true;
            this.btn_java_Annotations.Click += new System.EventHandler(this.btn_java_Annotations_Click);
            // 
            // btn_java_ok
            // 
            this.btn_java_ok.Location = new System.Drawing.Point(538, 64);
            this.btn_java_ok.Name = "btn_java_ok";
            this.btn_java_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_java_ok.TabIndex = 28;
            this.btn_java_ok.Text = "生成";
            this.btn_java_ok.UseVisualStyleBackColor = true;
            this.btn_java_ok.Click += new System.EventHandler(this.btn_java_ok_Click);
            // 
            // tbx_java_suffix
            // 
            this.tbx_java_suffix.Location = new System.Drawing.Point(367, 41);
            this.tbx_java_suffix.Name = "tbx_java_suffix";
            this.tbx_java_suffix.Size = new System.Drawing.Size(90, 21);
            this.tbx_java_suffix.TabIndex = 26;
            // 
            // tbx_java_prefix
            // 
            this.tbx_java_prefix.Location = new System.Drawing.Point(198, 43);
            this.tbx_java_prefix.Name = "tbx_java_prefix";
            this.tbx_java_prefix.Size = new System.Drawing.Size(90, 21);
            this.tbx_java_prefix.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "后缀";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "前缀";
            // 
            // rb_java_final
            // 
            this.rb_java_final.AutoSize = true;
            this.rb_java_final.Checked = true;
            this.rb_java_final.Location = new System.Drawing.Point(509, 19);
            this.rb_java_final.Name = "rb_java_final";
            this.rb_java_final.Size = new System.Drawing.Size(53, 16);
            this.rb_java_final.TabIndex = 20;
            this.rb_java_final.TabStop = true;
            this.rb_java_final.Text = "final";
            this.rb_java_final.UseVisualStyleBackColor = true;
            // 
            // rb_java_static
            // 
            this.rb_java_static.AutoSize = true;
            this.rb_java_static.Location = new System.Drawing.Point(408, 19);
            this.rb_java_static.Name = "rb_java_static";
            this.rb_java_static.Size = new System.Drawing.Size(59, 16);
            this.rb_java_static.TabIndex = 21;
            this.rb_java_static.Text = "static";
            this.rb_java_static.UseVisualStyleBackColor = true;
            // 
            // rb_java_private
            // 
            this.rb_java_private.AutoSize = true;
            this.rb_java_private.Location = new System.Drawing.Point(301, 19);
            this.rb_java_private.Name = "rb_java_private";
            this.rb_java_private.Size = new System.Drawing.Size(65, 16);
            this.rb_java_private.TabIndex = 22;
            this.rb_java_private.Text = "private";
            this.rb_java_private.UseVisualStyleBackColor = true;
            // 
            // rb_java_public
            // 
            this.rb_java_public.AutoSize = true;
            this.rb_java_public.Location = new System.Drawing.Point(200, 19);
            this.rb_java_public.Name = "rb_java_public";
            this.rb_java_public.Size = new System.Drawing.Size(59, 16);
            this.rb_java_public.TabIndex = 23;
            this.rb_java_public.Text = "public";
            this.rb_java_public.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "修饰符";
            // 
            // Style
            // 
            this.Style.Controls.Add(this.btn_style_ok);
            this.Style.Controls.Add(this.tbx_style_item_value);
            this.Style.Controls.Add(this.tbx_style_name);
            this.Style.Controls.Add(this.tbx_style_item_name);
            this.Style.Controls.Add(this.label1);
            this.Style.Controls.Add(this.label7);
            this.Style.Controls.Add(this.label6);
            this.Style.Controls.Add(this.label5);
            this.Style.Controls.Add(this.btn_style_init);
            this.Style.Location = new System.Drawing.Point(4, 22);
            this.Style.Name = "Style";
            this.Style.Padding = new System.Windows.Forms.Padding(3);
            this.Style.Size = new System.Drawing.Size(1123, 93);
            this.Style.TabIndex = 1;
            this.Style.Text = "Style";
            this.Style.UseVisualStyleBackColor = true;
            // 
            // btn_style_ok
            // 
            this.btn_style_ok.Location = new System.Drawing.Point(630, 54);
            this.btn_style_ok.Name = "btn_style_ok";
            this.btn_style_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_style_ok.TabIndex = 43;
            this.btn_style_ok.Text = "生成";
            this.btn_style_ok.UseVisualStyleBackColor = true;
            this.btn_style_ok.Click += new System.EventHandler(this.btn_style_ok_Click);
            // 
            // tbx_style_item_value
            // 
            this.tbx_style_item_value.Location = new System.Drawing.Point(395, 39);
            this.tbx_style_item_value.Name = "tbx_style_item_value";
            this.tbx_style_item_value.Size = new System.Drawing.Size(90, 21);
            this.tbx_style_item_value.TabIndex = 40;
            // 
            // tbx_style_name
            // 
            this.tbx_style_name.Location = new System.Drawing.Point(232, 6);
            this.tbx_style_name.Name = "tbx_style_name";
            this.tbx_style_name.Size = new System.Drawing.Size(90, 21);
            this.tbx_style_name.TabIndex = 41;
            // 
            // tbx_style_item_name
            // 
            this.tbx_style_item_name.Location = new System.Drawing.Point(232, 39);
            this.tbx_style_item_name.Name = "tbx_style_item_name";
            this.tbx_style_item_name.Size = new System.Drawing.Size(90, 21);
            this.tbx_style_item_name.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 37;
            this.label7.Text = "名称";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "正则过滤";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "name";
            // 
            // btn_style_init
            // 
            this.btn_style_init.Location = new System.Drawing.Point(21, 11);
            this.btn_style_init.Name = "btn_style_init";
            this.btn_style_init.Size = new System.Drawing.Size(75, 23);
            this.btn_style_init.TabIndex = 35;
            this.btn_style_init.Text = "初始化";
            this.btn_style_init.UseVisualStyleBackColor = true;
            this.btn_style_init.Click += new System.EventHandler(this.btn_style_init_Click);
            // 
            // ViewHolder
            // 
            this.ViewHolder.Controls.Add(this.cbx_viewholder_isUpper);
            this.ViewHolder.Controls.Add(this.cbx_listview);
            this.ViewHolder.Controls.Add(this.btn_viewHolder_init);
            this.ViewHolder.Controls.Add(this.btn_viewHolder_ok);
            this.ViewHolder.Controls.Add(this.tbx_viewholder_suffix);
            this.ViewHolder.Controls.Add(this.tbx_viewholder_prefix);
            this.ViewHolder.Controls.Add(this.label8);
            this.ViewHolder.Controls.Add(this.label9);
            this.ViewHolder.Controls.Add(this.rb_viewholder_final);
            this.ViewHolder.Controls.Add(this.rb_viewholder_static);
            this.ViewHolder.Controls.Add(this.rb_viewholder_private);
            this.ViewHolder.Controls.Add(this.rb_viewholder_public);
            this.ViewHolder.Controls.Add(this.label10);
            this.ViewHolder.Location = new System.Drawing.Point(4, 22);
            this.ViewHolder.Name = "ViewHolder";
            this.ViewHolder.Padding = new System.Windows.Forms.Padding(3);
            this.ViewHolder.Size = new System.Drawing.Size(1123, 93);
            this.ViewHolder.TabIndex = 3;
            this.ViewHolder.Text = "ViewHolder";
            this.ViewHolder.UseVisualStyleBackColor = true;
            // 
            // cbx_viewholder_isUpper
            // 
            this.cbx_viewholder_isUpper.AutoSize = true;
            this.cbx_viewholder_isUpper.Location = new System.Drawing.Point(293, 68);
            this.cbx_viewholder_isUpper.Name = "cbx_viewholder_isUpper";
            this.cbx_viewholder_isUpper.Size = new System.Drawing.Size(84, 16);
            this.cbx_viewholder_isUpper.TabIndex = 41;
            this.cbx_viewholder_isUpper.Text = "首字符大写";
            this.cbx_viewholder_isUpper.UseVisualStyleBackColor = true;
            // 
            // cbx_listview
            // 
            this.cbx_listview.AutoSize = true;
            this.cbx_listview.Location = new System.Drawing.Point(192, 66);
            this.cbx_listview.Name = "cbx_listview";
            this.cbx_listview.Size = new System.Drawing.Size(72, 16);
            this.cbx_listview.TabIndex = 40;
            this.cbx_listview.Text = "ListView";
            this.cbx_listview.UseVisualStyleBackColor = true;
            this.cbx_listview.Visible = false;
            // 
            // btn_viewHolder_init
            // 
            this.btn_viewHolder_init.Location = new System.Drawing.Point(17, 18);
            this.btn_viewHolder_init.Name = "btn_viewHolder_init";
            this.btn_viewHolder_init.Size = new System.Drawing.Size(75, 23);
            this.btn_viewHolder_init.TabIndex = 38;
            this.btn_viewHolder_init.Text = "初始化";
            this.btn_viewHolder_init.UseVisualStyleBackColor = true;
            this.btn_viewHolder_init.Click += new System.EventHandler(this.btn_viewHolder_init_Click);
            // 
            // btn_viewHolder_ok
            // 
            this.btn_viewHolder_ok.Location = new System.Drawing.Point(623, 61);
            this.btn_viewHolder_ok.Name = "btn_viewHolder_ok";
            this.btn_viewHolder_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_viewHolder_ok.TabIndex = 39;
            this.btn_viewHolder_ok.Text = "生成";
            this.btn_viewHolder_ok.UseVisualStyleBackColor = true;
            this.btn_viewHolder_ok.Click += new System.EventHandler(this.btn_viewHolder_ok_Click);
            // 
            // tbx_viewholder_suffix
            // 
            this.tbx_viewholder_suffix.Location = new System.Drawing.Point(359, 38);
            this.tbx_viewholder_suffix.Name = "tbx_viewholder_suffix";
            this.tbx_viewholder_suffix.Size = new System.Drawing.Size(90, 21);
            this.tbx_viewholder_suffix.TabIndex = 36;
            // 
            // tbx_viewholder_prefix
            // 
            this.tbx_viewholder_prefix.Location = new System.Drawing.Point(190, 40);
            this.tbx_viewholder_prefix.Name = "tbx_viewholder_prefix";
            this.tbx_viewholder_prefix.Size = new System.Drawing.Size(90, 21);
            this.tbx_viewholder_prefix.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 34;
            this.label8.Text = "后缀";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "前缀";
            // 
            // rb_viewholder_final
            // 
            this.rb_viewholder_final.AutoSize = true;
            this.rb_viewholder_final.Location = new System.Drawing.Point(501, 16);
            this.rb_viewholder_final.Name = "rb_viewholder_final";
            this.rb_viewholder_final.Size = new System.Drawing.Size(53, 16);
            this.rb_viewholder_final.TabIndex = 30;
            this.rb_viewholder_final.TabStop = true;
            this.rb_viewholder_final.Text = "final";
            this.rb_viewholder_final.UseVisualStyleBackColor = true;
            // 
            // rb_viewholder_static
            // 
            this.rb_viewholder_static.AutoSize = true;
            this.rb_viewholder_static.Location = new System.Drawing.Point(400, 16);
            this.rb_viewholder_static.Name = "rb_viewholder_static";
            this.rb_viewholder_static.Size = new System.Drawing.Size(59, 16);
            this.rb_viewholder_static.TabIndex = 31;
            this.rb_viewholder_static.TabStop = true;
            this.rb_viewholder_static.Text = "static";
            this.rb_viewholder_static.UseVisualStyleBackColor = true;
            // 
            // rb_viewholder_private
            // 
            this.rb_viewholder_private.AutoSize = true;
            this.rb_viewholder_private.Location = new System.Drawing.Point(293, 16);
            this.rb_viewholder_private.Name = "rb_viewholder_private";
            this.rb_viewholder_private.Size = new System.Drawing.Size(65, 16);
            this.rb_viewholder_private.TabIndex = 32;
            this.rb_viewholder_private.TabStop = true;
            this.rb_viewholder_private.Text = "private";
            this.rb_viewholder_private.UseVisualStyleBackColor = true;
            // 
            // rb_viewholder_public
            // 
            this.rb_viewholder_public.AutoSize = true;
            this.rb_viewholder_public.Location = new System.Drawing.Point(192, 16);
            this.rb_viewholder_public.Name = "rb_viewholder_public";
            this.rb_viewholder_public.Size = new System.Drawing.Size(59, 16);
            this.rb_viewholder_public.TabIndex = 33;
            this.rb_viewholder_public.TabStop = true;
            this.rb_viewholder_public.Text = "public";
            this.rb_viewholder_public.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "修饰符";
            // 
            // Json
            // 
            this.Json.Controls.Add(this.btn_json_init);
            this.Json.Controls.Add(this.tbx_json_name);
            this.Json.Controls.Add(this.label11);
            this.Json.Controls.Add(this.btn_json_ok);
            this.Json.Location = new System.Drawing.Point(4, 22);
            this.Json.Name = "Json";
            this.Json.Padding = new System.Windows.Forms.Padding(3);
            this.Json.Size = new System.Drawing.Size(1123, 93);
            this.Json.TabIndex = 2;
            this.Json.Text = "Json";
            this.Json.UseVisualStyleBackColor = true;
            // 
            // btn_json_init
            // 
            this.btn_json_init.Location = new System.Drawing.Point(19, 17);
            this.btn_json_init.Name = "btn_json_init";
            this.btn_json_init.Size = new System.Drawing.Size(75, 23);
            this.btn_json_init.TabIndex = 3;
            this.btn_json_init.Text = "初始化";
            this.btn_json_init.UseVisualStyleBackColor = true;
            this.btn_json_init.Click += new System.EventHandler(this.btn_json_init_Click);
            // 
            // tbx_json_name
            // 
            this.tbx_json_name.Location = new System.Drawing.Point(179, 40);
            this.tbx_json_name.Name = "tbx_json_name";
            this.tbx_json_name.Size = new System.Drawing.Size(100, 21);
            this.tbx_json_name.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(120, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "类名";
            // 
            // btn_json_ok
            // 
            this.btn_json_ok.Location = new System.Drawing.Point(448, 53);
            this.btn_json_ok.Name = "btn_json_ok";
            this.btn_json_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_json_ok.TabIndex = 0;
            this.btn_json_ok.Text = " 生成java类";
            this.btn_json_ok.UseVisualStyleBackColor = true;
            this.btn_json_ok.Click += new System.EventHandler(this.btn_json_ok_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tv_xml);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1129, 412);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.TabIndex = 11;
            // 
            // tv_xml
            // 
            this.tv_xml.AllowDrop = true;
            this.tv_xml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_xml.Location = new System.Drawing.Point(0, 0);
            this.tv_xml.Name = "tv_xml";
            this.tv_xml.Size = new System.Drawing.Size(376, 412);
            this.tv_xml.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(749, 412);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 567);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main";
            this.Text = "Android_gTools";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.StandardJava.ResumeLayout(false);
            this.StandardJava.PerformLayout();
            this.Style.ResumeLayout(false);
            this.Style.PerformLayout();
            this.ViewHolder.ResumeLayout(false);
            this.ViewHolder.PerformLayout();
            this.Json.ResumeLayout(false);
            this.Json.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StandardJava;
        private System.Windows.Forms.TabPage Style;
        private System.Windows.Forms.TabPage ViewHolder;
        private System.Windows.Forms.TabPage Json;
        private System.Windows.Forms.Button btn_java_init;
        private System.Windows.Forms.Button btn_java_ok;
        private System.Windows.Forms.TextBox tbx_java_suffix;
        private System.Windows.Forms.TextBox tbx_java_prefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_java_final;
        private System.Windows.Forms.RadioButton rb_java_static;
        private System.Windows.Forms.RadioButton rb_java_private;
        private System.Windows.Forms.RadioButton rb_java_public;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_style_ok;
        private System.Windows.Forms.TextBox tbx_style_item_value;
        private System.Windows.Forms.TextBox tbx_style_name;
        private System.Windows.Forms.TextBox tbx_style_item_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_style_init;
        private System.Windows.Forms.CheckBox cbx_listview;
        private System.Windows.Forms.Button btn_viewHolder_init;
        private System.Windows.Forms.Button btn_viewHolder_ok;
        private System.Windows.Forms.TextBox tbx_viewholder_suffix;
        private System.Windows.Forms.TextBox tbx_viewholder_prefix;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rb_viewholder_final;
        private System.Windows.Forms.RadioButton rb_viewholder_static;
        private System.Windows.Forms.RadioButton rb_viewholder_private;
        private System.Windows.Forms.RadioButton rb_viewholder_public;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_json_ok;
        private System.Windows.Forms.CheckBox cbx_java_isUpper;
        private System.Windows.Forms.CheckBox cbx_viewholder_isUpper;
        private System.Windows.Forms.TextBox tbx_json_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_json_init;
        private System.Windows.Forms.Button btn_java_Annotations;
        private System.Windows.Forms.Button btn_java_ViewInject;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tv_xml;
        private System.Windows.Forms.RichTextBox richTextBox1;



    }
}

