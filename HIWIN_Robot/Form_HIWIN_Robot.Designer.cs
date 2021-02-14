namespace HiwinRobot
{
    partial class Form_HIWIN_Robot
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
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_arm_motion_start = new System.Windows.Forms.Button();
            this.groupBox_connect_disconnect = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_arm_clear_alarm = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_position_type_descartes = new System.Windows.Forms.RadioButton();
            this.radioButton_position_type_joint = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_motion_type_point_to_point = new System.Windows.Forms.RadioButton();
            this.radioButton_motion_type_linear = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_coordinate_type_absolute = new System.Windows.Forms.RadioButton();
            this.radioButton_coordinate_type_relative = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_update_now_position = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_arm_to_zero_slow = new System.Windows.Forms.CheckBox();
            this.button_arm_homing = new System.Windows.Forms.Button();
            this.groupBox_arm_position = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_arm_now_positin = new System.Windows.Forms.Label();
            this.label_arm_target_position = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_arm_now_position_j1x = new System.Windows.Forms.TextBox();
            this.textBox_arm_now_position_j2y = new System.Windows.Forms.TextBox();
            this.textBox_arm_now_position_j3z = new System.Windows.Forms.TextBox();
            this.textBox_arm_now_position_j4a = new System.Windows.Forms.TextBox();
            this.textBox_arm_now_position_j5b = new System.Windows.Forms.TextBox();
            this.textBox_arm_now_position_j6c = new System.Windows.Forms.TextBox();
            this.numericUpDown_arm_target_position_j1x = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_arm_target_position_j2y = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_arm_target_position_j3z = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_arm_target_position_j4a = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_arm_target_position_j5b = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_arm_target_position_j6c = new System.Windows.Forms.NumericUpDown();
            this.button_arm_copy_position_from_now_to_target = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_arm_speed = new System.Windows.Forms.NumericUpDown();
            this.button_set_speed_acceleration = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_arm_acceleration = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button_gripper_action = new System.Windows.Forms.Button();
            this.numericUpDown_gripper_position = new System.Windows.Forms.NumericUpDown();
            this.button_gripper_reset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown_gripper_speed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_gripper_force = new System.Windows.Forms.NumericUpDown();
            this.tabControl_sub = new System.Windows.Forms.TabControl();
            this.tabPage_sub_position_record = new System.Windows.Forms.TabPage();
            this.textBox_position_record_name = new System.Windows.Forms.TextBox();
            this.groupBox_position_record = new System.Windows.Forms.GroupBox();
            this.button_position_recode = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_position_record_comment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listView_position_record = new System.Windows.Forms.ListView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.button_position_record_read = new System.Windows.Forms.Button();
            this.button_position_record_update_list = new System.Windows.Forms.Button();
            this.comboBox_position_record_file_list = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox_connect_disconnect.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_arm_position.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_target_position_j1x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_target_position_j2y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_target_position_j3z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_target_position_j4a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_target_position_j5b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_target_position_j6c)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_acceleration)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gripper_position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gripper_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gripper_force)).BeginInit();
            this.tabControl_sub.SuspendLayout();
            this.tabPage_sub_position_record.SuspendLayout();
            this.groupBox_position_record.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_connect.Location = new System.Drawing.Point(6, 6);
            this.button_connect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(204, 99);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_disconnect.Location = new System.Drawing.Point(222, 6);
            this.button_disconnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(204, 99);
            this.button_disconnect.TabIndex = 1;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_arm_motion_start
            // 
            this.button_arm_motion_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_arm_motion_start.Location = new System.Drawing.Point(35, 6);
            this.button_arm_motion_start.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_arm_motion_start.Name = "button_arm_motion_start";
            this.button_arm_motion_start.Size = new System.Drawing.Size(182, 64);
            this.button_arm_motion_start.TabIndex = 2;
            this.button_arm_motion_start.Text = "進行動作";
            this.button_arm_motion_start.UseVisualStyleBackColor = true;
            this.button_arm_motion_start.Click += new System.EventHandler(this.button_arm_motion_start_Click);
            // 
            // groupBox_connect_disconnect
            // 
            this.groupBox_connect_disconnect.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_connect_disconnect.Location = new System.Drawing.Point(24, 24);
            this.groupBox_connect_disconnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_connect_disconnect.Name = "groupBox_connect_disconnect";
            this.groupBox_connect_disconnect.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_connect_disconnect.Size = new System.Drawing.Size(660, 159);
            this.groupBox_connect_disconnect.TabIndex = 3;
            this.groupBox_connect_disconnect.TabStop = false;
            this.groupBox_connect_disconnect.Text = "連線與斷線";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button_connect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_disconnect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_arm_clear_alarm, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 42);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 111);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_arm_clear_alarm
            // 
            this.button_arm_clear_alarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_arm_clear_alarm.Location = new System.Drawing.Point(438, 6);
            this.button_arm_clear_alarm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_arm_clear_alarm.Name = "button_arm_clear_alarm";
            this.button_arm_clear_alarm.Size = new System.Drawing.Size(204, 99);
            this.button_arm_clear_alarm.TabIndex = 2;
            this.button_arm_clear_alarm.Text = "Clear Alarm";
            this.button_arm_clear_alarm.UseVisualStyleBackColor = true;
            this.button_arm_clear_alarm.Click += new System.EventHandler(this.button_arm_clear_alarm_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 42);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1386, 194);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_position_type_descartes);
            this.groupBox3.Controls.Add(this.radioButton_position_type_joint);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(536, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(253, 182);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "位置類型";
            // 
            // radioButton_position_type_descartes
            // 
            this.radioButton_position_type_descartes.AutoSize = true;
            this.radioButton_position_type_descartes.Checked = true;
            this.radioButton_position_type_descartes.Location = new System.Drawing.Point(12, 43);
            this.radioButton_position_type_descartes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton_position_type_descartes.Name = "radioButton_position_type_descartes";
            this.radioButton_position_type_descartes.Size = new System.Drawing.Size(140, 34);
            this.radioButton_position_type_descartes.TabIndex = 0;
            this.radioButton_position_type_descartes.TabStop = true;
            this.radioButton_position_type_descartes.Text = "笛卡爾";
            this.radioButton_position_type_descartes.UseVisualStyleBackColor = true;
            this.radioButton_position_type_descartes.CheckedChanged += new System.EventHandler(this.radioButton_position_type_descartes_CheckedChanged);
            // 
            // radioButton_position_type_joint
            // 
            this.radioButton_position_type_joint.AutoSize = true;
            this.radioButton_position_type_joint.Location = new System.Drawing.Point(12, 98);
            this.radioButton_position_type_joint.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton_position_type_joint.Name = "radioButton_position_type_joint";
            this.radioButton_position_type_joint.Size = new System.Drawing.Size(110, 34);
            this.radioButton_position_type_joint.TabIndex = 0;
            this.radioButton_position_type_joint.Text = "關節";
            this.radioButton_position_type_joint.UseVisualStyleBackColor = true;
            this.radioButton_position_type_joint.CheckedChanged += new System.EventHandler(this.radioButton_position_type_joint_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_motion_type_point_to_point);
            this.groupBox1.Controls.Add(this.radioButton_motion_type_linear);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(253, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "運動類型";
            // 
            // radioButton_motion_type_point_to_point
            // 
            this.radioButton_motion_type_point_to_point.AutoSize = true;
            this.radioButton_motion_type_point_to_point.Checked = true;
            this.radioButton_motion_type_point_to_point.Location = new System.Drawing.Point(12, 49);
            this.radioButton_motion_type_point_to_point.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton_motion_type_point_to_point.Name = "radioButton_motion_type_point_to_point";
            this.radioButton_motion_type_point_to_point.Size = new System.Drawing.Size(200, 34);
            this.radioButton_motion_type_point_to_point.TabIndex = 0;
            this.radioButton_motion_type_point_to_point.TabStop = true;
            this.radioButton_motion_type_point_to_point.Text = "點到點運動";
            this.radioButton_motion_type_point_to_point.UseVisualStyleBackColor = true;
            // 
            // radioButton_motion_type_linear
            // 
            this.radioButton_motion_type_linear.AutoSize = true;
            this.radioButton_motion_type_linear.Location = new System.Drawing.Point(12, 98);
            this.radioButton_motion_type_linear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton_motion_type_linear.Name = "radioButton_motion_type_linear";
            this.radioButton_motion_type_linear.Size = new System.Drawing.Size(170, 34);
            this.radioButton_motion_type_linear.TabIndex = 0;
            this.radioButton_motion_type_linear.Text = "直線運動";
            this.radioButton_motion_type_linear.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_coordinate_type_absolute);
            this.groupBox2.Controls.Add(this.radioButton_coordinate_type_relative);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(271, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(253, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "坐標類型";
            // 
            // radioButton_coordinate_type_absolute
            // 
            this.radioButton_coordinate_type_absolute.AutoSize = true;
            this.radioButton_coordinate_type_absolute.Checked = true;
            this.radioButton_coordinate_type_absolute.Location = new System.Drawing.Point(12, 43);
            this.radioButton_coordinate_type_absolute.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton_coordinate_type_absolute.Name = "radioButton_coordinate_type_absolute";
            this.radioButton_coordinate_type_absolute.Size = new System.Drawing.Size(170, 34);
            this.radioButton_coordinate_type_absolute.TabIndex = 0;
            this.radioButton_coordinate_type_absolute.TabStop = true;
            this.radioButton_coordinate_type_absolute.Text = "絕對坐標";
            this.radioButton_coordinate_type_absolute.UseVisualStyleBackColor = true;
            this.radioButton_coordinate_type_absolute.CheckedChanged += new System.EventHandler(this.radioButton_coordinate_type_absolute_CheckedChanged);
            // 
            // radioButton_coordinate_type_relative
            // 
            this.radioButton_coordinate_type_relative.AutoSize = true;
            this.radioButton_coordinate_type_relative.Location = new System.Drawing.Point(12, 98);
            this.radioButton_coordinate_type_relative.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton_coordinate_type_relative.Name = "radioButton_coordinate_type_relative";
            this.radioButton_coordinate_type_relative.Size = new System.Drawing.Size(170, 34);
            this.radioButton_coordinate_type_relative.TabIndex = 0;
            this.radioButton_coordinate_type_relative.Text = "相對坐標";
            this.radioButton_coordinate_type_relative.UseVisualStyleBackColor = true;
            this.radioButton_coordinate_type_relative.CheckedChanged += new System.EventHandler(this.radioButton_coordinate_type_relative_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.button_arm_motion_start, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_update_now_position, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(861, 6);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(253, 152);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // button_update_now_position
            // 
            this.button_update_now_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_update_now_position.Location = new System.Drawing.Point(35, 82);
            this.button_update_now_position.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_update_now_position.Name = "button_update_now_position";
            this.button_update_now_position.Size = new System.Drawing.Size(182, 64);
            this.button_update_now_position.TabIndex = 3;
            this.button_update_now_position.Text = "更新位置";
            this.button_update_now_position.UseVisualStyleBackColor = true;
            this.button_update_now_position.Click += new System.EventHandler(this.button_update_now_position_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_arm_to_zero_slow);
            this.groupBox4.Controls.Add(this.button_arm_homing);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(1126, 6);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(254, 182);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "原點";
            // 
            // checkBox_arm_to_zero_slow
            // 
            this.checkBox_arm_to_zero_slow.AutoSize = true;
            this.checkBox_arm_to_zero_slow.Checked = true;
            this.checkBox_arm_to_zero_slow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_arm_to_zero_slow.Location = new System.Drawing.Point(38, 120);
            this.checkBox_arm_to_zero_slow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox_arm_to_zero_slow.Name = "checkBox_arm_to_zero_slow";
            this.checkBox_arm_to_zero_slow.Size = new System.Drawing.Size(178, 34);
            this.checkBox_arm_to_zero_slow.TabIndex = 1;
            this.checkBox_arm_to_zero_slow.Text = "以5%速度";
            this.checkBox_arm_to_zero_slow.UseVisualStyleBackColor = true;
            // 
            // button_arm_homing
            // 
            this.button_arm_homing.Location = new System.Drawing.Point(38, 43);
            this.button_arm_homing.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_arm_homing.Name = "button_arm_homing";
            this.button_arm_homing.Size = new System.Drawing.Size(186, 64);
            this.button_arm_homing.TabIndex = 0;
            this.button_arm_homing.Text = "回到原點";
            this.button_arm_homing.UseVisualStyleBackColor = true;
            this.button_arm_homing.Click += new System.EventHandler(this.button_arm_homing_Click);
            // 
            // groupBox_arm_position
            // 
            this.groupBox_arm_position.Controls.Add(this.tableLayoutPanel2);
            this.groupBox_arm_position.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_arm_position.Location = new System.Drawing.Point(6, 6);
            this.groupBox_arm_position.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_arm_position.Name = "groupBox_arm_position";
            this.groupBox_arm_position.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_arm_position.Size = new System.Drawing.Size(1398, 356);
            this.groupBox_arm_position.TabIndex = 0;
            this.groupBox_arm_position.TabStop = false;
            this.groupBox_arm_position.Text = "位置";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.label_arm_now_positin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_arm_target_position, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_arm_now_position_j1x, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_arm_now_position_j2y, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_arm_now_position_j3z, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_arm_now_position_j4a, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_arm_now_position_j5b, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_arm_now_position_j6c, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_arm_target_position_j1x, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_arm_target_position_j2y, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_arm_target_position_j3z, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_arm_target_position_j4a, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_arm_target_position_j5b, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_arm_target_position_j6c, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_arm_copy_position_from_now_to_target, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 42);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1386, 308);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label_arm_now_positin
            // 
            this.label_arm_now_positin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_arm_now_positin.AutoSize = true;
            this.label_arm_now_positin.Location = new System.Drawing.Point(29, 44);
            this.label_arm_now_positin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_arm_now_positin.Name = "label_arm_now_positin";
            this.label_arm_now_positin.Size = new System.Drawing.Size(103, 30);
            this.label_arm_now_positin.TabIndex = 0;
            this.label_arm_now_positin.Text = "目前：";
            // 
            // label_arm_target_position
            // 
            this.label_arm_target_position.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_arm_target_position.AutoSize = true;
            this.label_arm_target_position.Location = new System.Drawing.Point(29, 233);
            this.label_arm_target_position.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_arm_target_position.Name = "label_arm_target_position";
            this.label_arm_target_position.Size = new System.Drawing.Size(103, 30);
            this.label_arm_target_position.TabIndex = 0;
            this.label_arm_target_position.Text = "目標：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "J1/X";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "J2/Y";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "J3/Z";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(829, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "J4/A";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1037, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "J5/B";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1247, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "J6/C";
            // 
            // textBox_arm_now_position_j1x
            // 
            this.textBox_arm_now_position_j1x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_arm_now_position_j1x.Location = new System.Drawing.Point(144, 38);
            this.textBox_arm_now_position_j1x.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_arm_now_position_j1x.Name = "textBox_arm_now_position_j1x";
            this.textBox_arm_now_position_j1x.Size = new System.Drawing.Size(195, 43);
            this.textBox_arm_now_position_j1x.TabIndex = 2;
            this.textBox_arm_now_position_j1x.Text = "--";
            // 
            // textBox_arm_now_position_j2y
            // 
            this.textBox_arm_now_position_j2y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_arm_now_position_j2y.Location = new System.Drawing.Point(351, 38);
            this.textBox_arm_now_position_j2y.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_arm_now_position_j2y.Name = "textBox_arm_now_position_j2y";
            this.textBox_arm_now_position_j2y.Size = new System.Drawing.Size(195, 43);
            this.textBox_arm_now_position_j2y.TabIndex = 2;
            this.textBox_arm_now_position_j2y.Text = "--";
            // 
            // textBox_arm_now_position_j3z
            // 
            this.textBox_arm_now_position_j3z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_arm_now_position_j3z.Location = new System.Drawing.Point(558, 38);
            this.textBox_arm_now_position_j3z.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_arm_now_position_j3z.Name = "textBox_arm_now_position_j3z";
            this.textBox_arm_now_position_j3z.Size = new System.Drawing.Size(195, 43);
            this.textBox_arm_now_position_j3z.TabIndex = 2;
            this.textBox_arm_now_position_j3z.Text = "--";
            // 
            // textBox_arm_now_position_j4a
            // 
            this.textBox_arm_now_position_j4a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_arm_now_position_j4a.Location = new System.Drawing.Point(765, 38);
            this.textBox_arm_now_position_j4a.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_arm_now_position_j4a.Name = "textBox_arm_now_position_j4a";
            this.textBox_arm_now_position_j4a.Size = new System.Drawing.Size(195, 43);
            this.textBox_arm_now_position_j4a.TabIndex = 2;
            this.textBox_arm_now_position_j4a.Text = "--";
            // 
            // textBox_arm_now_position_j5b
            // 
            this.textBox_arm_now_position_j5b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_arm_now_position_j5b.Location = new System.Drawing.Point(972, 38);
            this.textBox_arm_now_position_j5b.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_arm_now_position_j5b.Name = "textBox_arm_now_position_j5b";
            this.textBox_arm_now_position_j5b.Size = new System.Drawing.Size(195, 43);
            this.textBox_arm_now_position_j5b.TabIndex = 2;
            this.textBox_arm_now_position_j5b.Text = "--";
            // 
            // textBox_arm_now_position_j6c
            // 
            this.textBox_arm_now_position_j6c.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_arm_now_position_j6c.Location = new System.Drawing.Point(1179, 38);
            this.textBox_arm_now_position_j6c.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_arm_now_position_j6c.Name = "textBox_arm_now_position_j6c";
            this.textBox_arm_now_position_j6c.Size = new System.Drawing.Size(201, 43);
            this.textBox_arm_now_position_j6c.TabIndex = 2;
            this.textBox_arm_now_position_j6c.Text = "--";
            // 
            // numericUpDown_arm_target_position_j1x
            // 
            this.numericUpDown_arm_target_position_j1x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_arm_target_position_j1x.DecimalPlaces = 3;
            this.numericUpDown_arm_target_position_j1x.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_arm_target_position_j1x.Location = new System.Drawing.Point(144, 226);
            this.numericUpDown_arm_target_position_j1x.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDown_arm_target_position_j1x.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDown_arm_target_position_j1x.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            -2147483648});
            this.numericUpDown_arm_target_position_j1x.Name = "numericUpDown_arm_target_position_j1x";
            this.numericUpDown_arm_target_position_j1x.Size = new System.Drawing.Size(195, 43);
            this.numericUpDown_arm_target_position_j1x.TabIndex = 3;
            // 
            // numericUpDown_arm_target_position_j2y
            // 
            this.numericUpDown_arm_target_position_j2y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_arm_target_position_j2y.DecimalPlaces = 3;
            this.numericUpDown_arm_target_position_j2y.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_arm_target_position_j2y.Location = new System.Drawing.Point(351, 226);
            this.numericUpDown_arm_target_position_j2y.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDown_arm_target_position_j2y.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDown_arm_target_position_j2y.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            -2147483648});
            this.numericUpDown_arm_target_position_j2y.Name = "numericUpDown_arm_target_position_j2y";
            this.numericUpDown_arm_target_position_j2y.Size = new System.Drawing.Size(195, 43);
            this.numericUpDown_arm_target_position_j2y.TabIndex = 3;
            this.numericUpDown_arm_target_position_j2y.Value = new decimal(new int[] {
            368,
            0,
            0,
            0});
            // 
            // numericUpDown_arm_target_position_j3z
            // 
            this.numericUpDown_arm_target_position_j3z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_arm_target_position_j3z.DecimalPlaces = 3;
            this.numericUpDown_arm_target_position_j3z.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_arm_target_position_j3z.Location = new System.Drawing.Point(558, 226);
            this.numericUpDown_arm_target_position_j3z.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDown_arm_target_position_j3z.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_arm_target_position_j3z.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericUpDown_arm_target_position_j3z.Name = "numericUpDown_arm_target_position_j3z";
            this.numericUpDown_arm_target_position_j3z.Size = new System.Drawing.Size(195, 43);
            this.numericUpDown_arm_target_position_j3z.TabIndex = 3;
            this.numericUpDown_arm_target_position_j3z.Value = new decimal(new int[] {
            294,
            0,
            0,
            0});
            // 
            // numericUpDown_arm_target_position_j4a
            // 
            this.numericUpDown_arm_target_position_j4a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_arm_target_position_j4a.DecimalPlaces = 3;
            this.numericUpDown_arm_target_position_j4a.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_arm_target_position_j4a.Location = new System.Drawing.Point(765, 226);
            this.numericUpDown_arm_target_position_j4a.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDown_arm_target_position_j4a.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDown_arm_target_position_j4a.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            -2147483648});
            this.numericUpDown_arm_target_position_j4a.Name = "numericUpDown_arm_target_position_j4a";
            this.numericUpDown_arm_target_position_j4a.Size = new System.Drawing.Size(195, 43);
            this.numericUpDown_arm_target_position_j4a.TabIndex = 3;
            this.numericUpDown_arm_target_position_j4a.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // numericUpDown_arm_target_position_j5b
            // 
            this.numericUpDown_arm_target_position_j5b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_arm_target_position_j5b.DecimalPlaces = 3;
            this.numericUpDown_arm_target_position_j5b.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_arm_target_position_j5b.Location = new System.Drawing.Point(972, 226);
            this.numericUpDown_arm_target_position_j5b.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDown_arm_target_position_j5b.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDown_arm_target_position_j5b.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            -2147483648});
            this.numericUpDown_arm_target_position_j5b.Name = "numericUpDown_arm_target_position_j5b";
            this.numericUpDown_arm_target_position_j5b.Size = new System.Drawing.Size(195, 43);
            this.numericUpDown_arm_target_position_j5b.TabIndex = 3;
            // 
            // numericUpDown_arm_target_position_j6c
            // 
            this.numericUpDown_arm_target_position_j6c.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_arm_target_position_j6c.DecimalPlaces = 3;
            this.numericUpDown_arm_target_position_j6c.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_arm_target_position_j6c.Location = new System.Drawing.Point(1179, 226);
            this.numericUpDown_arm_target_position_j6c.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDown_arm_target_position_j6c.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDown_arm_target_position_j6c.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            -2147483648});
            this.numericUpDown_arm_target_position_j6c.Name = "numericUpDown_arm_target_position_j6c";
            this.numericUpDown_arm_target_position_j6c.Size = new System.Drawing.Size(201, 43);
            this.numericUpDown_arm_target_position_j6c.TabIndex = 3;
            this.numericUpDown_arm_target_position_j6c.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // button_arm_copy_position_from_now_to_target
            // 
            this.button_arm_copy_position_from_now_to_target.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_arm_copy_position_from_now_to_target.Location = new System.Drawing.Point(6, 125);
            this.button_arm_copy_position_from_now_to_target.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_arm_copy_position_from_now_to_target.Name = "button_arm_copy_position_from_now_to_target";
            this.button_arm_copy_position_from_now_to_target.Size = new System.Drawing.Size(126, 57);
            this.button_arm_copy_position_from_now_to_target.TabIndex = 4;
            this.button_arm_copy_position_from_now_to_target.Text = "複製";
            this.button_arm_copy_position_from_now_to_target.UseVisualStyleBackColor = true;
            this.button_arm_copy_position_from_now_to_target.Click += new System.EventHandler(this.button_arm_copy_position_from_now_to_target_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(6, 604);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Size = new System.Drawing.Size(1398, 201);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "速度與加速度";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.Controls.Add(this.numericUpDown_arm_speed, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_set_speed_acceleration, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.numericUpDown_arm_acceleration, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 42);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1386, 153);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // numericUpDown_arm_speed
            // 
            this.numericUpDown_arm_speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_arm_speed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_arm_speed.Location = new System.Drawing.Point(275, 55);
            this.numericUpDown_arm_speed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDown_arm_speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_arm_speed.Name = "numericUpDown_arm_speed";
            this.numericUpDown_arm_speed.Size = new System.Drawing.Size(257, 43);
            this.numericUpDown_arm_speed.TabIndex = 0;
            this.numericUpDown_arm_speed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button_set_speed_acceleration
            // 
            this.button_set_speed_acceleration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_set_speed_acceleration.Location = new System.Drawing.Point(1122, 53);
            this.button_set_speed_acceleration.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_set_speed_acceleration.Name = "button_set_speed_acceleration";
            this.button_set_speed_acceleration.Size = new System.Drawing.Size(258, 47);
            this.button_set_speed_acceleration.TabIndex = 1;
            this.button_set_speed_acceleration.Text = "設定";
            this.button_set_speed_acceleration.UseVisualStyleBackColor = true;
            this.button_set_speed_acceleration.Click += new System.EventHandler(this.button_set_speed_acceleration_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "速度：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "加速度：";
            // 
            // numericUpDown_arm_acceleration
            // 
            this.numericUpDown_arm_acceleration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_arm_acceleration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_arm_acceleration.Location = new System.Drawing.Point(813, 55);
            this.numericUpDown_arm_acceleration.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDown_arm_acceleration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_arm_acceleration.Name = "numericUpDown_arm_acceleration";
            this.numericUpDown_arm_acceleration.Size = new System.Drawing.Size(257, 43);
            this.numericUpDown_arm_acceleration.TabIndex = 0;
            this.numericUpDown_arm_acceleration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel3);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(6, 362);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox6.Size = new System.Drawing.Size(1398, 242);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "動作";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 197);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1430, 943);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox_arm_position);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1410, 885);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "手臂";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel6);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1410, 885);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "夾爪";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.button_gripper_action, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown_gripper_position, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.button_gripper_reset, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown_gripper_speed, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown_gripper_force, 1, 3);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(74, 88);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(506, 488);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // button_gripper_action
            // 
            this.button_gripper_action.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_gripper_action.Location = new System.Drawing.Point(304, 37);
            this.button_gripper_action.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_gripper_action.Name = "button_gripper_action";
            this.button_gripper_action.Size = new System.Drawing.Size(150, 47);
            this.button_gripper_action.TabIndex = 3;
            this.button_gripper_action.Text = "進行動作";
            this.button_gripper_action.UseVisualStyleBackColor = true;
            this.button_gripper_action.Click += new System.EventHandler(this.button_gripper_action_Click);
            // 
            // numericUpDown_gripper_position
            // 
            this.numericUpDown_gripper_position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_gripper_position.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_gripper_position.Location = new System.Drawing.Point(259, 161);
            this.numericUpDown_gripper_position.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDown_gripper_position.Maximum = new decimal(new int[] {
            3200,
            0,
            0,
            0});
            this.numericUpDown_gripper_position.Name = "numericUpDown_gripper_position";
            this.numericUpDown_gripper_position.Size = new System.Drawing.Size(241, 43);
            this.numericUpDown_gripper_position.TabIndex = 1;
            this.numericUpDown_gripper_position.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // button_gripper_reset
            // 
            this.button_gripper_reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_gripper_reset.Location = new System.Drawing.Point(51, 37);
            this.button_gripper_reset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_gripper_reset.Name = "button_gripper_reset";
            this.button_gripper_reset.Size = new System.Drawing.Size(150, 47);
            this.button_gripper_reset.TabIndex = 0;
            this.button_gripper_reset.Text = "重置";
            this.button_gripper_reset.UseVisualStyleBackColor = true;
            this.button_gripper_reset.Click += new System.EventHandler(this.button_gripper_reset_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 30);
            this.label9.TabIndex = 4;
            this.label9.Text = "距離：";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(144, 290);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 30);
            this.label10.TabIndex = 4;
            this.label10.Text = "速度：";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(144, 412);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 30);
            this.label11.TabIndex = 4;
            this.label11.Text = "力量：";
            // 
            // numericUpDown_gripper_speed
            // 
            this.numericUpDown_gripper_speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_gripper_speed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_gripper_speed.Location = new System.Drawing.Point(259, 283);
            this.numericUpDown_gripper_speed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDown_gripper_speed.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDown_gripper_speed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_gripper_speed.Name = "numericUpDown_gripper_speed";
            this.numericUpDown_gripper_speed.Size = new System.Drawing.Size(241, 43);
            this.numericUpDown_gripper_speed.TabIndex = 1;
            this.numericUpDown_gripper_speed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown_gripper_force
            // 
            this.numericUpDown_gripper_force.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_gripper_force.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_gripper_force.Location = new System.Drawing.Point(259, 405);
            this.numericUpDown_gripper_force.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDown_gripper_force.Name = "numericUpDown_gripper_force";
            this.numericUpDown_gripper_force.Size = new System.Drawing.Size(241, 43);
            this.numericUpDown_gripper_force.TabIndex = 1;
            this.numericUpDown_gripper_force.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // tabControl_sub
            // 
            this.tabControl_sub.Controls.Add(this.tabPage_sub_position_record);
            this.tabControl_sub.Location = new System.Drawing.Point(1489, 197);
            this.tabControl_sub.Name = "tabControl_sub";
            this.tabControl_sub.SelectedIndex = 0;
            this.tabControl_sub.Size = new System.Drawing.Size(1331, 943);
            this.tabControl_sub.TabIndex = 6;
            // 
            // tabPage_sub_position_record
            // 
            this.tabPage_sub_position_record.Controls.Add(this.groupBox7);
            this.tabPage_sub_position_record.Controls.Add(this.groupBox_position_record);
            this.tabPage_sub_position_record.Location = new System.Drawing.Point(10, 48);
            this.tabPage_sub_position_record.Name = "tabPage_sub_position_record";
            this.tabPage_sub_position_record.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_sub_position_record.Size = new System.Drawing.Size(1311, 885);
            this.tabPage_sub_position_record.TabIndex = 0;
            this.tabPage_sub_position_record.Text = "位置記錄";
            this.tabPage_sub_position_record.UseVisualStyleBackColor = true;
            // 
            // textBox_position_record_name
            // 
            this.textBox_position_record_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_position_record_name.Location = new System.Drawing.Point(132, 35);
            this.textBox_position_record_name.Name = "textBox_position_record_name";
            this.textBox_position_record_name.Size = new System.Drawing.Size(383, 43);
            this.textBox_position_record_name.TabIndex = 0;
            this.textBox_position_record_name.Text = "位置記錄";
            // 
            // groupBox_position_record
            // 
            this.groupBox_position_record.Controls.Add(this.tableLayoutPanel7);
            this.groupBox_position_record.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_position_record.Location = new System.Drawing.Point(3, 727);
            this.groupBox_position_record.Name = "groupBox_position_record";
            this.groupBox_position_record.Size = new System.Drawing.Size(1305, 155);
            this.groupBox_position_record.TabIndex = 1;
            this.groupBox_position_record.TabStop = false;
            this.groupBox_position_record.Text = "記錄";
            // 
            // button_position_recode
            // 
            this.button_position_recode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_position_recode.Location = new System.Drawing.Point(1169, 27);
            this.button_position_recode.Name = "button_position_recode";
            this.button_position_recode.Size = new System.Drawing.Size(127, 59);
            this.button_position_recode.TabIndex = 1;
            this.button_position_recode.Text = "記錄";
            this.button_position_recode.UseVisualStyleBackColor = true;
            this.button_position_recode.Click += new System.EventHandler(this.button_position_recode_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 5;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.Controls.Add(this.button_position_recode, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBox_position_record_name, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBox_position_record_comment, 3, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1299, 113);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // textBox_position_record_comment
            // 
            this.textBox_position_record_comment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_position_record_comment.Location = new System.Drawing.Point(650, 35);
            this.textBox_position_record_comment.Name = "textBox_position_record_comment";
            this.textBox_position_record_comment.Size = new System.Drawing.Size(513, 43);
            this.textBox_position_record_comment.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(541, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 30);
            this.label12.TabIndex = 3;
            this.label12.Text = "備註：";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 30);
            this.label13.TabIndex = 3;
            this.label13.Text = "名稱：";
            // 
            // listView_position_record
            // 
            this.listView_position_record.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView_position_record.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView_position_record.FullRowSelect = true;
            this.listView_position_record.GridLines = true;
            this.listView_position_record.HideSelection = false;
            this.listView_position_record.Location = new System.Drawing.Point(3, 39);
            this.listView_position_record.MultiSelect = false;
            this.listView_position_record.Name = "listView_position_record";
            this.listView_position_record.Size = new System.Drawing.Size(1299, 580);
            this.listView_position_record.TabIndex = 2;
            this.listView_position_record.UseCompatibleStateImageBehavior = false;
            this.listView_position_record.View = System.Windows.Forms.View.Details;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel8);
            this.groupBox7.Controls.Add(this.listView_position_record);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1305, 724);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "讀取";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Controls.Add(this.button_position_record_read, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.button_position_record_update_list, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.comboBox_position_record_file_list, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 625);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1299, 96);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // button_position_record_read
            // 
            this.button_position_record_read.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_position_record_read.Location = new System.Drawing.Point(1062, 12);
            this.button_position_record_read.Name = "button_position_record_read";
            this.button_position_record_read.Size = new System.Drawing.Size(146, 72);
            this.button_position_record_read.TabIndex = 0;
            this.button_position_record_read.Text = "讀取";
            this.button_position_record_read.UseVisualStyleBackColor = true;
            this.button_position_record_read.Click += new System.EventHandler(this.button_position_record_read_Click);
            // 
            // button_position_record_update_list
            // 
            this.button_position_record_update_list.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_position_record_update_list.Location = new System.Drawing.Point(737, 12);
            this.button_position_record_update_list.Name = "button_position_record_update_list";
            this.button_position_record_update_list.Size = new System.Drawing.Size(146, 72);
            this.button_position_record_update_list.TabIndex = 0;
            this.button_position_record_update_list.Text = "更新";
            this.button_position_record_update_list.UseVisualStyleBackColor = true;
            this.button_position_record_update_list.Click += new System.EventHandler(this.button_position_record_update_list_Click);
            // 
            // comboBox_position_record_file_list
            // 
            this.comboBox_position_record_file_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_position_record_file_list.FormattingEnabled = true;
            this.comboBox_position_record_file_list.Location = new System.Drawing.Point(327, 29);
            this.comboBox_position_record_file_list.Name = "comboBox_position_record_file_list";
            this.comboBox_position_record_file_list.Size = new System.Drawing.Size(318, 38);
            this.comboBox_position_record_file_list.TabIndex = 1;
            this.comboBox_position_record_file_list.SelectedIndexChanged += new System.EventHandler(this.comboBox_position_record_file_list_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(158, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 30);
            this.label14.TabIndex = 2;
            this.label14.Text = "選擇檔案：";
            // 
            // Form_HIWIN_Robot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2916, 1339);
            this.Controls.Add(this.tabControl_sub);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox_connect_disconnect);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_HIWIN_Robot";
            this.Text = "HIWIN Robot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_HIWIN_Robot_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_HIWIN_Robot_KeyDown);
            this.groupBox_connect_disconnect.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox_arm_position.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_target_position_j1x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_target_position_j2y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_target_position_j3z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_target_position_j4a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_target_position_j5b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_target_position_j6c)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arm_acceleration)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gripper_position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gripper_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gripper_force)).EndInit();
            this.tabControl_sub.ResumeLayout(false);
            this.tabPage_sub_position_record.ResumeLayout(false);
            this.groupBox_position_record.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button button_arm_motion_start;
        private System.Windows.Forms.GroupBox groupBox_connect_disconnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_arm_clear_alarm;
        private System.Windows.Forms.GroupBox groupBox_arm_position;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_arm_now_positin;
        private System.Windows.Forms.Label label_arm_target_position;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_arm_now_position_j1x;
        private System.Windows.Forms.TextBox textBox_arm_now_position_j2y;
        private System.Windows.Forms.TextBox textBox_arm_now_position_j3z;
        private System.Windows.Forms.TextBox textBox_arm_now_position_j4a;
        private System.Windows.Forms.TextBox textBox_arm_now_position_j5b;
        private System.Windows.Forms.TextBox textBox_arm_now_position_j6c;
        private System.Windows.Forms.NumericUpDown numericUpDown_arm_target_position_j1x;
        private System.Windows.Forms.NumericUpDown numericUpDown_arm_target_position_j2y;
        private System.Windows.Forms.NumericUpDown numericUpDown_arm_target_position_j3z;
        private System.Windows.Forms.NumericUpDown numericUpDown_arm_target_position_j4a;
        private System.Windows.Forms.NumericUpDown numericUpDown_arm_target_position_j5b;
        private System.Windows.Forms.NumericUpDown numericUpDown_arm_target_position_j6c;
        private System.Windows.Forms.Button button_arm_copy_position_from_now_to_target;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_motion_type_linear;
        private System.Windows.Forms.RadioButton radioButton_motion_type_point_to_point;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_coordinate_type_absolute;
        private System.Windows.Forms.RadioButton radioButton_coordinate_type_relative;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_position_type_descartes;
        private System.Windows.Forms.RadioButton radioButton_position_type_joint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox_arm_to_zero_slow;
        private System.Windows.Forms.Button button_arm_homing;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.NumericUpDown numericUpDown_arm_speed;
        private System.Windows.Forms.Button button_set_speed_acceleration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_arm_acceleration;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button_gripper_action;
        private System.Windows.Forms.NumericUpDown numericUpDown_gripper_position;
        private System.Windows.Forms.Button button_gripper_reset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_gripper_speed;
        private System.Windows.Forms.NumericUpDown numericUpDown_gripper_force;
        private System.Windows.Forms.Button button_update_now_position;
        private System.Windows.Forms.TabControl tabControl_sub;
        private System.Windows.Forms.TabPage tabPage_sub_position_record;
        private System.Windows.Forms.GroupBox groupBox_position_record;
        private System.Windows.Forms.TextBox textBox_position_record_name;
        private System.Windows.Forms.Button button_position_recode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_position_record_comment;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListView listView_position_record;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button button_position_record_read;
        private System.Windows.Forms.Button button_position_record_update_list;
        private System.Windows.Forms.ComboBox comboBox_position_record_file_list;
        private System.Windows.Forms.Label label14;
    }
}

