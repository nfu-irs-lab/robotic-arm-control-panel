namespace MainForm
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
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_arm_motion_start = new System.Windows.Forms.Button();
            this.groupBox_connect_disconnect = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_arm_clear_alarm = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_coordinate_type_descartes = new System.Windows.Forms.RadioButton();
            this.radioButton_coordinate_type_joint = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_motion_type_point_to_point = new System.Windows.Forms.RadioButton();
            this.radioButton_motion_type_linear = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_position_type_absolute = new System.Windows.Forms.RadioButton();
            this.radioButton_position_type_relative = new System.Windows.Forms.RadioButton();
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
            this.tabPage_sub_actionflow = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.listView_actionflow_actions = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_actionflow_autoNext = new System.Windows.Forms.CheckBox();
            this.button_actionflow_do_all = new System.Windows.Forms.Button();
            this.button_actionflow_do_selected = new System.Windows.Forms.Button();
            this.checkBox_actionflow_showMsg = new System.Windows.Forms.CheckBox();
            this.tabPage_sub_position_record = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.button_position_record_read = new System.Windows.Forms.Button();
            this.button_position_record_update_list = new System.Windows.Forms.Button();
            this.comboBox_position_record_file_list = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.listView_position_record = new System.Windows.Forms.ListView();
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
            this.groupBox_position_record = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.button_position_recode = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_position_record_name = new System.Windows.Forms.TextBox();
            this.textBox_position_record_comment = new System.Windows.Forms.TextBox();
            this.tabPage_sub_inching = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButtonInchingModeContinuousWide = new System.Windows.Forms.RadioButton();
            this.radioButtonInchingModeContinuousNarrow = new System.Windows.Forms.RadioButton();
            this.radioButtonInchingModeSingle = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.button_inching_negative_z = new System.Windows.Forms.Button();
            this.button_inching_positive_z = new System.Windows.Forms.Button();
            this.button_inching_negative_y = new System.Windows.Forms.Button();
            this.button_inching_positive_x = new System.Windows.Forms.Button();
            this.button_inching_negative_x = new System.Windows.Forms.Button();
            this.button_inching_positive_y = new System.Windows.Forms.Button();
            this.numericUpDown_inching_z = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_inching_xy = new System.Windows.Forms.NumericUpDown();
            this.tabPage_sub_camera = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_camera_freerun = new System.Windows.Forms.CheckBox();
            this.button_camera_open = new System.Windows.Forms.Button();
            this.button_camera_setting = new System.Windows.Forms.Button();
            this.button_camera_close = new System.Windows.Forms.Button();
            this.button_camera_choose = new System.Windows.Forms.Button();
            this.button_camera_snapshot = new System.Windows.Forms.Button();
            this.pictureBox_camera = new System.Windows.Forms.PictureBox();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_basic_control = new System.Windows.Forms.TabPage();
            this.tabPage_exclusive_control = new System.Windows.Forms.TabPage();
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
            this.tabPage_sub_actionflow.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tabPage_sub_position_record.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox_position_record.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabPage_sub_inching.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inching_z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inching_xy)).BeginInit();
            this.tabPage_sub_camera.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).BeginInit();
            this.tabControl_main.SuspendLayout();
            this.tabPage_basic_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_connect.Location = new System.Drawing.Point(5, 6);
            this.button_connect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(179, 103);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_disconnect.Location = new System.Drawing.Point(194, 6);
            this.button_disconnect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(179, 103);
            this.button_disconnect.TabIndex = 1;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_arm_motion_start
            // 
            this.button_arm_motion_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_arm_motion_start.Location = new System.Drawing.Point(31, 14);
            this.button_arm_motion_start.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_arm_motion_start.Name = "button_arm_motion_start";
            this.button_arm_motion_start.Size = new System.Drawing.Size(159, 62);
            this.button_arm_motion_start.TabIndex = 2;
            this.button_arm_motion_start.Text = "進行動作";
            this.button_arm_motion_start.UseVisualStyleBackColor = true;
            this.button_arm_motion_start.Click += new System.EventHandler(this.button_arm_motion_start_Click);
            // 
            // groupBox_connect_disconnect
            // 
            this.groupBox_connect_disconnect.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_connect_disconnect.Location = new System.Drawing.Point(21, 23);
            this.groupBox_connect_disconnect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox_connect_disconnect.Name = "groupBox_connect_disconnect";
            this.groupBox_connect_disconnect.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox_connect_disconnect.Size = new System.Drawing.Size(578, 155);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 34);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 115);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_arm_clear_alarm
            // 
            this.button_arm_clear_alarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_arm_clear_alarm.Location = new System.Drawing.Point(383, 6);
            this.button_arm_clear_alarm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_arm_clear_alarm.Name = "button_arm_clear_alarm";
            this.button_arm_clear_alarm.Size = new System.Drawing.Size(180, 103);
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
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 34);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1211, 194);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_coordinate_type_descartes);
            this.groupBox3.Controls.Add(this.radioButton_coordinate_type_joint);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(467, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Size = new System.Drawing.Size(221, 182);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "座標類型";
            // 
            // radioButton_coordinate_type_descartes
            // 
            this.radioButton_coordinate_type_descartes.AutoSize = true;
            this.radioButton_coordinate_type_descartes.Checked = true;
            this.radioButton_coordinate_type_descartes.Location = new System.Drawing.Point(10, 43);
            this.radioButton_coordinate_type_descartes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButton_coordinate_type_descartes.Name = "radioButton_coordinate_type_descartes";
            this.radioButton_coordinate_type_descartes.Size = new System.Drawing.Size(164, 33);
            this.radioButton_coordinate_type_descartes.TabIndex = 0;
            this.radioButton_coordinate_type_descartes.TabStop = true;
            this.radioButton_coordinate_type_descartes.Text = "笛卡爾座標";
            this.radioButton_coordinate_type_descartes.UseVisualStyleBackColor = true;
            this.radioButton_coordinate_type_descartes.CheckedChanged += new System.EventHandler(this.radioButton_coordinate_type_descartes_CheckedChanged);
            // 
            // radioButton_coordinate_type_joint
            // 
            this.radioButton_coordinate_type_joint.AutoSize = true;
            this.radioButton_coordinate_type_joint.Location = new System.Drawing.Point(10, 95);
            this.radioButton_coordinate_type_joint.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButton_coordinate_type_joint.Name = "radioButton_coordinate_type_joint";
            this.radioButton_coordinate_type_joint.Size = new System.Drawing.Size(140, 33);
            this.radioButton_coordinate_type_joint.TabIndex = 0;
            this.radioButton_coordinate_type_joint.Text = "關節座標";
            this.radioButton_coordinate_type_joint.UseVisualStyleBackColor = true;
            this.radioButton_coordinate_type_joint.CheckedChanged += new System.EventHandler(this.radioButton_coordinate_type_joint_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_motion_type_point_to_point);
            this.groupBox1.Controls.Add(this.radioButton_motion_type_linear);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(221, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "運動類型";
            // 
            // radioButton_motion_type_point_to_point
            // 
            this.radioButton_motion_type_point_to_point.AutoSize = true;
            this.radioButton_motion_type_point_to_point.Checked = true;
            this.radioButton_motion_type_point_to_point.Location = new System.Drawing.Point(10, 46);
            this.radioButton_motion_type_point_to_point.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButton_motion_type_point_to_point.Name = "radioButton_motion_type_point_to_point";
            this.radioButton_motion_type_point_to_point.Size = new System.Drawing.Size(164, 33);
            this.radioButton_motion_type_point_to_point.TabIndex = 0;
            this.radioButton_motion_type_point_to_point.TabStop = true;
            this.radioButton_motion_type_point_to_point.Text = "點到點運動";
            this.radioButton_motion_type_point_to_point.UseVisualStyleBackColor = true;
            // 
            // radioButton_motion_type_linear
            // 
            this.radioButton_motion_type_linear.AutoSize = true;
            this.radioButton_motion_type_linear.Location = new System.Drawing.Point(10, 95);
            this.radioButton_motion_type_linear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButton_motion_type_linear.Name = "radioButton_motion_type_linear";
            this.radioButton_motion_type_linear.Size = new System.Drawing.Size(140, 33);
            this.radioButton_motion_type_linear.TabIndex = 0;
            this.radioButton_motion_type_linear.Text = "直線運動";
            this.radioButton_motion_type_linear.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_position_type_absolute);
            this.groupBox2.Controls.Add(this.radioButton_position_type_relative);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(236, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(221, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "位置類型";
            // 
            // radioButton_position_type_absolute
            // 
            this.radioButton_position_type_absolute.AutoSize = true;
            this.radioButton_position_type_absolute.Checked = true;
            this.radioButton_position_type_absolute.Location = new System.Drawing.Point(10, 43);
            this.radioButton_position_type_absolute.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButton_position_type_absolute.Name = "radioButton_position_type_absolute";
            this.radioButton_position_type_absolute.Size = new System.Drawing.Size(134, 33);
            this.radioButton_position_type_absolute.TabIndex = 0;
            this.radioButton_position_type_absolute.TabStop = true;
            this.radioButton_position_type_absolute.Text = "絕對位置";
            this.radioButton_position_type_absolute.UseVisualStyleBackColor = true;
            this.radioButton_position_type_absolute.CheckedChanged += new System.EventHandler(this.radioButton_position_type_absolute_CheckedChanged);
            // 
            // radioButton_position_type_relative
            // 
            this.radioButton_position_type_relative.AutoSize = true;
            this.radioButton_position_type_relative.Location = new System.Drawing.Point(10, 95);
            this.radioButton_position_type_relative.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButton_position_type_relative.Name = "radioButton_position_type_relative";
            this.radioButton_position_type_relative.Size = new System.Drawing.Size(140, 33);
            this.radioButton_position_type_relative.TabIndex = 0;
            this.radioButton_position_type_relative.Text = "相對位置";
            this.radioButton_position_type_relative.UseVisualStyleBackColor = true;
            this.radioButton_position_type_relative.CheckedChanged += new System.EventHandler(this.radioButton_position_type_relative_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.button_arm_motion_start, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_update_now_position, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(750, 6);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(221, 182);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // button_update_now_position
            // 
            this.button_update_now_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_update_now_position.Location = new System.Drawing.Point(31, 104);
            this.button_update_now_position.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_update_now_position.Name = "button_update_now_position";
            this.button_update_now_position.Size = new System.Drawing.Size(159, 64);
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
            this.groupBox4.Location = new System.Drawing.Point(981, 6);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox4.Size = new System.Drawing.Size(225, 182);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "原點";
            // 
            // checkBox_arm_to_zero_slow
            // 
            this.checkBox_arm_to_zero_slow.AutoSize = true;
            this.checkBox_arm_to_zero_slow.Checked = true;
            this.checkBox_arm_to_zero_slow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_arm_to_zero_slow.Location = new System.Drawing.Point(33, 116);
            this.checkBox_arm_to_zero_slow.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkBox_arm_to_zero_slow.Name = "checkBox_arm_to_zero_slow";
            this.checkBox_arm_to_zero_slow.Size = new System.Drawing.Size(152, 33);
            this.checkBox_arm_to_zero_slow.TabIndex = 1;
            this.checkBox_arm_to_zero_slow.Text = "以5%速度";
            this.checkBox_arm_to_zero_slow.UseVisualStyleBackColor = true;
            // 
            // button_arm_homing
            // 
            this.button_arm_homing.Location = new System.Drawing.Point(33, 43);
            this.button_arm_homing.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_arm_homing.Name = "button_arm_homing";
            this.button_arm_homing.Size = new System.Drawing.Size(163, 62);
            this.button_arm_homing.TabIndex = 0;
            this.button_arm_homing.Text = "回到原點";
            this.button_arm_homing.UseVisualStyleBackColor = true;
            this.button_arm_homing.Click += new System.EventHandler(this.button_arm_homing_Click);
            // 
            // groupBox_arm_position
            // 
            this.groupBox_arm_position.Controls.Add(this.tableLayoutPanel2);
            this.groupBox_arm_position.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_arm_position.Location = new System.Drawing.Point(5, 6);
            this.groupBox_arm_position.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox_arm_position.Name = "groupBox_arm_position";
            this.groupBox_arm_position.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox_arm_position.Size = new System.Drawing.Size(1221, 344);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 34);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1211, 304);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label_arm_now_positin
            // 
            this.label_arm_now_positin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_arm_now_positin.AutoSize = true;
            this.label_arm_now_positin.Location = new System.Drawing.Point(43, 45);
            this.label_arm_now_positin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_arm_now_positin.Name = "label_arm_now_positin";
            this.label_arm_now_positin.Size = new System.Drawing.Size(73, 29);
            this.label_arm_now_positin.TabIndex = 0;
            this.label_arm_now_positin.Text = "目前：";
            // 
            // label_arm_target_position
            // 
            this.label_arm_target_position.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_arm_target_position.AutoSize = true;
            this.label_arm_target_position.Location = new System.Drawing.Point(43, 230);
            this.label_arm_target_position.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_arm_target_position.Name = "label_arm_target_position";
            this.label_arm_target_position.Size = new System.Drawing.Size(73, 29);
            this.label_arm_target_position.TabIndex = 0;
            this.label_arm_target_position.Text = "目標：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "J1/X";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "J2/Y";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "J3/Z";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "J4/A";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(905, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "J5/B";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1087, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "J6/C";
            // 
            // textBox_arm_now_position_j1x
            // 
            this.textBox_arm_now_position_j1x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_arm_now_position_j1x.Location = new System.Drawing.Point(126, 42);
            this.textBox_arm_now_position_j1x.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_arm_now_position_j1x.Name = "textBox_arm_now_position_j1x";
            this.textBox_arm_now_position_j1x.Size = new System.Drawing.Size(171, 35);
            this.textBox_arm_now_position_j1x.TabIndex = 2;
            this.textBox_arm_now_position_j1x.Text = "--";
            // 
            // textBox_arm_now_position_j2y
            // 
            this.textBox_arm_now_position_j2y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_arm_now_position_j2y.Location = new System.Drawing.Point(307, 42);
            this.textBox_arm_now_position_j2y.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_arm_now_position_j2y.Name = "textBox_arm_now_position_j2y";
            this.textBox_arm_now_position_j2y.Size = new System.Drawing.Size(171, 35);
            this.textBox_arm_now_position_j2y.TabIndex = 2;
            this.textBox_arm_now_position_j2y.Text = "--";
            // 
            // textBox_arm_now_position_j3z
            // 
            this.textBox_arm_now_position_j3z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_arm_now_position_j3z.Location = new System.Drawing.Point(488, 42);
            this.textBox_arm_now_position_j3z.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_arm_now_position_j3z.Name = "textBox_arm_now_position_j3z";
            this.textBox_arm_now_position_j3z.Size = new System.Drawing.Size(171, 35);
            this.textBox_arm_now_position_j3z.TabIndex = 2;
            this.textBox_arm_now_position_j3z.Text = "--";
            // 
            // textBox_arm_now_position_j4a
            // 
            this.textBox_arm_now_position_j4a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_arm_now_position_j4a.Location = new System.Drawing.Point(669, 42);
            this.textBox_arm_now_position_j4a.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_arm_now_position_j4a.Name = "textBox_arm_now_position_j4a";
            this.textBox_arm_now_position_j4a.Size = new System.Drawing.Size(171, 35);
            this.textBox_arm_now_position_j4a.TabIndex = 2;
            this.textBox_arm_now_position_j4a.Text = "--";
            // 
            // textBox_arm_now_position_j5b
            // 
            this.textBox_arm_now_position_j5b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_arm_now_position_j5b.Location = new System.Drawing.Point(850, 42);
            this.textBox_arm_now_position_j5b.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_arm_now_position_j5b.Name = "textBox_arm_now_position_j5b";
            this.textBox_arm_now_position_j5b.Size = new System.Drawing.Size(171, 35);
            this.textBox_arm_now_position_j5b.TabIndex = 2;
            this.textBox_arm_now_position_j5b.Text = "--";
            // 
            // textBox_arm_now_position_j6c
            // 
            this.textBox_arm_now_position_j6c.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_arm_now_position_j6c.Location = new System.Drawing.Point(1031, 42);
            this.textBox_arm_now_position_j6c.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_arm_now_position_j6c.Name = "textBox_arm_now_position_j6c";
            this.textBox_arm_now_position_j6c.Size = new System.Drawing.Size(175, 35);
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
            this.numericUpDown_arm_target_position_j1x.Location = new System.Drawing.Point(126, 227);
            this.numericUpDown_arm_target_position_j1x.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.numericUpDown_arm_target_position_j1x.Size = new System.Drawing.Size(171, 35);
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
            this.numericUpDown_arm_target_position_j2y.Location = new System.Drawing.Point(307, 227);
            this.numericUpDown_arm_target_position_j2y.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.numericUpDown_arm_target_position_j2y.Size = new System.Drawing.Size(171, 35);
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
            this.numericUpDown_arm_target_position_j3z.Location = new System.Drawing.Point(488, 227);
            this.numericUpDown_arm_target_position_j3z.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.numericUpDown_arm_target_position_j3z.Size = new System.Drawing.Size(171, 35);
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
            this.numericUpDown_arm_target_position_j4a.Location = new System.Drawing.Point(669, 227);
            this.numericUpDown_arm_target_position_j4a.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.numericUpDown_arm_target_position_j4a.Size = new System.Drawing.Size(171, 35);
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
            this.numericUpDown_arm_target_position_j5b.Location = new System.Drawing.Point(850, 227);
            this.numericUpDown_arm_target_position_j5b.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.numericUpDown_arm_target_position_j5b.Size = new System.Drawing.Size(171, 35);
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
            this.numericUpDown_arm_target_position_j6c.Location = new System.Drawing.Point(1031, 227);
            this.numericUpDown_arm_target_position_j6c.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.numericUpDown_arm_target_position_j6c.Size = new System.Drawing.Size(175, 35);
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
            this.button_arm_copy_position_from_now_to_target.Location = new System.Drawing.Point(5, 125);
            this.button_arm_copy_position_from_now_to_target.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_arm_copy_position_from_now_to_target.Name = "button_arm_copy_position_from_now_to_target";
            this.button_arm_copy_position_from_now_to_target.Size = new System.Drawing.Size(110, 54);
            this.button_arm_copy_position_from_now_to_target.TabIndex = 4;
            this.button_arm_copy_position_from_now_to_target.Text = "複製";
            this.button_arm_copy_position_from_now_to_target.UseVisualStyleBackColor = true;
            this.button_arm_copy_position_from_now_to_target.Click += new System.EventHandler(this.button_arm_copy_position_from_now_to_target_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(5, 584);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox5.Size = new System.Drawing.Size(1221, 193);
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
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.Controls.Add(this.numericUpDown_arm_speed, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_set_speed_acceleration, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.numericUpDown_arm_acceleration, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(5, 34);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1211, 153);
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
            this.numericUpDown_arm_speed.Location = new System.Drawing.Point(240, 59);
            this.numericUpDown_arm_speed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown_arm_speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_arm_speed.Name = "numericUpDown_arm_speed";
            this.numericUpDown_arm_speed.Size = new System.Drawing.Size(225, 35);
            this.numericUpDown_arm_speed.TabIndex = 0;
            this.numericUpDown_arm_speed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_set_speed_acceleration
            // 
            this.button_set_speed_acceleration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_set_speed_acceleration.Location = new System.Drawing.Point(980, 53);
            this.button_set_speed_acceleration.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_set_speed_acceleration.Name = "button_set_speed_acceleration";
            this.button_set_speed_acceleration.Size = new System.Drawing.Size(226, 46);
            this.button_set_speed_acceleration.TabIndex = 1;
            this.button_set_speed_acceleration.Text = "設定";
            this.button_set_speed_acceleration.UseVisualStyleBackColor = true;
            this.button_set_speed_acceleration.Click += new System.EventHandler(this.button_set_speed_acceleration_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "速度：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 29);
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
            this.numericUpDown_arm_acceleration.Location = new System.Drawing.Point(710, 59);
            this.numericUpDown_arm_acceleration.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown_arm_acceleration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_arm_acceleration.Name = "numericUpDown_arm_acceleration";
            this.numericUpDown_arm_acceleration.Size = new System.Drawing.Size(225, 35);
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
            this.groupBox6.Location = new System.Drawing.Point(5, 350);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox6.Size = new System.Drawing.Size(1221, 234);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "動作";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1251, 913);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox_arm_position);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage1.Size = new System.Drawing.Size(1231, 856);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "手臂";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel6);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Size = new System.Drawing.Size(1231, 856);
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
            this.tableLayoutPanel6.Location = new System.Drawing.Point(65, 85);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(443, 472);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // button_gripper_action
            // 
            this.button_gripper_action.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_gripper_action.Location = new System.Drawing.Point(266, 36);
            this.button_gripper_action.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_gripper_action.Name = "button_gripper_action";
            this.button_gripper_action.Size = new System.Drawing.Size(131, 46);
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
            this.numericUpDown_gripper_position.Location = new System.Drawing.Point(226, 159);
            this.numericUpDown_gripper_position.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown_gripper_position.Maximum = new decimal(new int[] {
            3200,
            0,
            0,
            0});
            this.numericUpDown_gripper_position.Name = "numericUpDown_gripper_position";
            this.numericUpDown_gripper_position.Size = new System.Drawing.Size(212, 35);
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
            this.button_gripper_reset.Location = new System.Drawing.Point(45, 36);
            this.button_gripper_reset.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_gripper_reset.Name = "button_gripper_reset";
            this.button_gripper_reset.Size = new System.Drawing.Size(131, 46);
            this.button_gripper_reset.TabIndex = 0;
            this.button_gripper_reset.Text = "重置";
            this.button_gripper_reset.UseVisualStyleBackColor = true;
            this.button_gripper_reset.Click += new System.EventHandler(this.button_gripper_reset_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "距離：";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 280);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "速度：";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 398);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 29);
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
            this.numericUpDown_gripper_speed.Location = new System.Drawing.Point(226, 277);
            this.numericUpDown_gripper_speed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.numericUpDown_gripper_speed.Size = new System.Drawing.Size(212, 35);
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
            this.numericUpDown_gripper_force.Location = new System.Drawing.Point(226, 395);
            this.numericUpDown_gripper_force.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown_gripper_force.Name = "numericUpDown_gripper_force";
            this.numericUpDown_gripper_force.Size = new System.Drawing.Size(212, 35);
            this.numericUpDown_gripper_force.TabIndex = 1;
            this.numericUpDown_gripper_force.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // tabControl_sub
            // 
            this.tabControl_sub.Controls.Add(this.tabPage_sub_actionflow);
            this.tabControl_sub.Controls.Add(this.tabPage_sub_position_record);
            this.tabControl_sub.Controls.Add(this.tabPage_sub_inching);
            this.tabControl_sub.Controls.Add(this.tabPage_sub_camera);
            this.tabControl_sub.Location = new System.Drawing.Point(1268, 9);
            this.tabControl_sub.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_sub.Name = "tabControl_sub";
            this.tabControl_sub.SelectedIndex = 0;
            this.tabControl_sub.Size = new System.Drawing.Size(1166, 913);
            this.tabControl_sub.TabIndex = 6;
            // 
            // tabPage_sub_actionflow
            // 
            this.tabPage_sub_actionflow.Controls.Add(this.tableLayoutPanel9);
            this.tabPage_sub_actionflow.Location = new System.Drawing.Point(10, 47);
            this.tabPage_sub_actionflow.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_sub_actionflow.Name = "tabPage_sub_actionflow";
            this.tabPage_sub_actionflow.Size = new System.Drawing.Size(1146, 856);
            this.tabPage_sub_actionflow.TabIndex = 1;
            this.tabPage_sub_actionflow.Text = "動作流程";
            this.tabPage_sub_actionflow.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.Controls.Add(this.listView_actionflow_actions, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1146, 856);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // listView_actionflow_actions
            // 
            this.listView_actionflow_actions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listView_actionflow_actions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_actionflow_actions.FullRowSelect = true;
            this.listView_actionflow_actions.GridLines = true;
            this.listView_actionflow_actions.HideSelection = false;
            this.listView_actionflow_actions.Location = new System.Drawing.Point(4, 4);
            this.listView_actionflow_actions.Margin = new System.Windows.Forms.Padding(4);
            this.listView_actionflow_actions.Name = "listView_actionflow_actions";
            this.listView_actionflow_actions.Size = new System.Drawing.Size(1144, 719);
            this.listView_actionflow_actions.TabIndex = 2;
            this.listView_actionflow_actions.UseCompatibleStateImageBehavior = false;
            this.listView_actionflow_actions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Index";
            this.columnHeader11.Width = 76;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Name";
            this.columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Comment";
            this.columnHeader13.Width = 1145;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 4;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel10.Controls.Add(this.checkBox_actionflow_autoNext, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.button_actionflow_do_all, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.button_actionflow_do_selected, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.checkBox_actionflow_showMsg, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(4, 731);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1144, 121);
            this.tableLayoutPanel10.TabIndex = 3;
            // 
            // checkBox_actionflow_autoNext
            // 
            this.checkBox_actionflow_autoNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_actionflow_autoNext.AutoSize = true;
            this.checkBox_actionflow_autoNext.Checked = true;
            this.checkBox_actionflow_autoNext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_actionflow_autoNext.Location = new System.Drawing.Point(256, 44);
            this.checkBox_actionflow_autoNext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkBox_actionflow_autoNext.Name = "checkBox_actionflow_autoNext";
            this.checkBox_actionflow_autoNext.Size = new System.Drawing.Size(241, 33);
            this.checkBox_actionflow_autoNext.TabIndex = 7;
            this.checkBox_actionflow_autoNext.Text = "Auto Next";
            this.checkBox_actionflow_autoNext.UseVisualStyleBackColor = true;
            this.checkBox_actionflow_autoNext.CheckedChanged += new System.EventHandler(this.checkBox_actionflow_autoNext_CheckedChanged);
            // 
            // button_actionflow_do_all
            // 
            this.button_actionflow_do_all.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_actionflow_do_all.Location = new System.Drawing.Point(901, 11);
            this.button_actionflow_do_all.Margin = new System.Windows.Forms.Padding(4);
            this.button_actionflow_do_all.Name = "button_actionflow_do_all";
            this.button_actionflow_do_all.Size = new System.Drawing.Size(164, 99);
            this.button_actionflow_do_all.TabIndex = 0;
            this.button_actionflow_do_all.Text = "執行全部";
            this.button_actionflow_do_all.UseVisualStyleBackColor = true;
            this.button_actionflow_do_all.Click += new System.EventHandler(this.button_actionflow_do_all_Click);
            // 
            // button_actionflow_do_selected
            // 
            this.button_actionflow_do_selected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_actionflow_do_selected.Location = new System.Drawing.Point(580, 11);
            this.button_actionflow_do_selected.Margin = new System.Windows.Forms.Padding(4);
            this.button_actionflow_do_selected.Name = "button_actionflow_do_selected";
            this.button_actionflow_do_selected.Size = new System.Drawing.Size(164, 99);
            this.button_actionflow_do_selected.TabIndex = 0;
            this.button_actionflow_do_selected.Text = "執行一次";
            this.button_actionflow_do_selected.UseVisualStyleBackColor = true;
            this.button_actionflow_do_selected.Click += new System.EventHandler(this.button_actionflow_do_selected_Click);
            // 
            // checkBox_actionflow_showMsg
            // 
            this.checkBox_actionflow_showMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_actionflow_showMsg.AutoSize = true;
            this.checkBox_actionflow_showMsg.Checked = true;
            this.checkBox_actionflow_showMsg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_actionflow_showMsg.Location = new System.Drawing.Point(5, 44);
            this.checkBox_actionflow_showMsg.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkBox_actionflow_showMsg.Name = "checkBox_actionflow_showMsg";
            this.checkBox_actionflow_showMsg.Size = new System.Drawing.Size(241, 33);
            this.checkBox_actionflow_showMsg.TabIndex = 8;
            this.checkBox_actionflow_showMsg.Text = "Show Msg";
            this.checkBox_actionflow_showMsg.UseVisualStyleBackColor = true;
            this.checkBox_actionflow_showMsg.CheckedChanged += new System.EventHandler(this.checkBox_actionflow_showMsg_CheckedChanged);
            // 
            // tabPage_sub_position_record
            // 
            this.tabPage_sub_position_record.Controls.Add(this.groupBox7);
            this.tabPage_sub_position_record.Controls.Add(this.groupBox_position_record);
            this.tabPage_sub_position_record.Location = new System.Drawing.Point(10, 47);
            this.tabPage_sub_position_record.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_sub_position_record.Name = "tabPage_sub_position_record";
            this.tabPage_sub_position_record.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_sub_position_record.Size = new System.Drawing.Size(1146, 856);
            this.tabPage_sub_position_record.TabIndex = 0;
            this.tabPage_sub_position_record.Text = "位置記錄";
            this.tabPage_sub_position_record.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel8);
            this.groupBox7.Controls.Add(this.listView_position_record);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(4, 4);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(1138, 697);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "讀取";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Controls.Add(this.button_position_record_read, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.button_position_record_update_list, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.comboBox_position_record_file_list, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 600);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1130, 93);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // button_position_record_read
            // 
            this.button_position_record_read.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_position_record_read.Location = new System.Drawing.Point(924, 11);
            this.button_position_record_read.Margin = new System.Windows.Forms.Padding(4);
            this.button_position_record_read.Name = "button_position_record_read";
            this.button_position_record_read.Size = new System.Drawing.Size(128, 70);
            this.button_position_record_read.TabIndex = 0;
            this.button_position_record_read.Text = "讀取";
            this.button_position_record_read.UseVisualStyleBackColor = true;
            this.button_position_record_read.Click += new System.EventHandler(this.button_position_record_read_Click);
            // 
            // button_position_record_update_list
            // 
            this.button_position_record_update_list.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_position_record_update_list.Location = new System.Drawing.Point(641, 11);
            this.button_position_record_update_list.Margin = new System.Windows.Forms.Padding(4);
            this.button_position_record_update_list.Name = "button_position_record_update_list";
            this.button_position_record_update_list.Size = new System.Drawing.Size(128, 70);
            this.button_position_record_update_list.TabIndex = 0;
            this.button_position_record_update_list.Text = "更新";
            this.button_position_record_update_list.UseVisualStyleBackColor = true;
            this.button_position_record_update_list.Click += new System.EventHandler(this.button_position_record_update_list_Click);
            // 
            // comboBox_position_record_file_list
            // 
            this.comboBox_position_record_file_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_position_record_file_list.FormattingEnabled = true;
            this.comboBox_position_record_file_list.Location = new System.Drawing.Point(173, 28);
            this.comboBox_position_record_file_list.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_position_record_file_list.Name = "comboBox_position_record_file_list";
            this.comboBox_position_record_file_list.Size = new System.Drawing.Size(387, 37);
            this.comboBox_position_record_file_list.TabIndex = 1;
            this.comboBox_position_record_file_list.SelectedIndexChanged += new System.EventHandler(this.comboBox_position_record_file_list_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 32);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 29);
            this.label14.TabIndex = 2;
            this.label14.Text = "選擇檔案：";
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
            this.listView_position_record.Location = new System.Drawing.Point(4, 32);
            this.listView_position_record.Margin = new System.Windows.Forms.Padding(4);
            this.listView_position_record.MultiSelect = false;
            this.listView_position_record.Name = "listView_position_record";
            this.listView_position_record.Size = new System.Drawing.Size(1130, 561);
            this.listView_position_record.TabIndex = 2;
            this.listView_position_record.UseCompatibleStateImageBehavior = false;
            this.listView_position_record.View = System.Windows.Forms.View.Details;
            // 
            // groupBox_position_record
            // 
            this.groupBox_position_record.Controls.Add(this.tableLayoutPanel7);
            this.groupBox_position_record.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_position_record.Location = new System.Drawing.Point(4, 701);
            this.groupBox_position_record.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_position_record.Name = "groupBox_position_record";
            this.groupBox_position_record.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_position_record.Size = new System.Drawing.Size(1138, 151);
            this.groupBox_position_record.TabIndex = 1;
            this.groupBox_position_record.TabStop = false;
            this.groupBox_position_record.Text = "記錄";
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
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 32);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1130, 115);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // button_position_recode
            // 
            this.button_position_recode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_position_recode.Location = new System.Drawing.Point(1021, 28);
            this.button_position_recode.Margin = new System.Windows.Forms.Padding(4);
            this.button_position_recode.Name = "button_position_recode";
            this.button_position_recode.Size = new System.Drawing.Size(105, 58);
            this.button_position_recode.TabIndex = 1;
            this.button_position_recode.Text = "記錄";
            this.button_position_recode.UseVisualStyleBackColor = true;
            this.button_position_recode.Click += new System.EventHandler(this.button_position_recode_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(488, 43);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 29);
            this.label12.TabIndex = 3;
            this.label12.Text = "備註：";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 43);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 29);
            this.label13.TabIndex = 3;
            this.label13.Text = "名稱：";
            // 
            // textBox_position_record_name
            // 
            this.textBox_position_record_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_position_record_name.Location = new System.Drawing.Point(117, 40);
            this.textBox_position_record_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_position_record_name.Name = "textBox_position_record_name";
            this.textBox_position_record_name.Size = new System.Drawing.Size(331, 35);
            this.textBox_position_record_name.TabIndex = 0;
            this.textBox_position_record_name.Text = "位置記錄";
            // 
            // textBox_position_record_comment
            // 
            this.textBox_position_record_comment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_position_record_comment.Location = new System.Drawing.Point(569, 40);
            this.textBox_position_record_comment.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_position_record_comment.Name = "textBox_position_record_comment";
            this.textBox_position_record_comment.Size = new System.Drawing.Size(444, 35);
            this.textBox_position_record_comment.TabIndex = 2;
            // 
            // tabPage_sub_inching
            // 
            this.tabPage_sub_inching.Controls.Add(this.groupBox8);
            this.tabPage_sub_inching.Controls.Add(this.tableLayoutPanel11);
            this.tabPage_sub_inching.Location = new System.Drawing.Point(10, 47);
            this.tabPage_sub_inching.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage_sub_inching.Name = "tabPage_sub_inching";
            this.tabPage_sub_inching.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage_sub_inching.Size = new System.Drawing.Size(1146, 856);
            this.tabPage_sub_inching.TabIndex = 2;
            this.tabPage_sub_inching.Text = "寸動微調";
            this.tabPage_sub_inching.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.radioButtonInchingModeContinuousWide);
            this.groupBox8.Controls.Add(this.radioButtonInchingModeContinuousNarrow);
            this.groupBox8.Controls.Add(this.radioButtonInchingModeSingle);
            this.groupBox8.Location = new System.Drawing.Point(72, 584);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox8.Size = new System.Drawing.Size(240, 261);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "模式";
            // 
            // radioButtonInchingModeContinuousWide
            // 
            this.radioButtonInchingModeContinuousWide.AutoSize = true;
            this.radioButtonInchingModeContinuousWide.Location = new System.Drawing.Point(10, 143);
            this.radioButtonInchingModeContinuousWide.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButtonInchingModeContinuousWide.Name = "radioButtonInchingModeContinuousWide";
            this.radioButtonInchingModeContinuousWide.Size = new System.Drawing.Size(164, 33);
            this.radioButtonInchingModeContinuousWide.TabIndex = 7;
            this.radioButtonInchingModeContinuousWide.TabStop = true;
            this.radioButtonInchingModeContinuousWide.Text = "連續大範圍";
            this.radioButtonInchingModeContinuousWide.UseVisualStyleBackColor = true;
            // 
            // radioButtonInchingModeContinuousNarrow
            // 
            this.radioButtonInchingModeContinuousNarrow.AutoSize = true;
            this.radioButtonInchingModeContinuousNarrow.Location = new System.Drawing.Point(10, 95);
            this.radioButtonInchingModeContinuousNarrow.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButtonInchingModeContinuousNarrow.Name = "radioButtonInchingModeContinuousNarrow";
            this.radioButtonInchingModeContinuousNarrow.Size = new System.Drawing.Size(164, 33);
            this.radioButtonInchingModeContinuousNarrow.TabIndex = 7;
            this.radioButtonInchingModeContinuousNarrow.TabStop = true;
            this.radioButtonInchingModeContinuousNarrow.Text = "連續小範圍";
            this.radioButtonInchingModeContinuousNarrow.UseVisualStyleBackColor = true;
            // 
            // radioButtonInchingModeSingle
            // 
            this.radioButtonInchingModeSingle.AutoSize = true;
            this.radioButtonInchingModeSingle.Checked = true;
            this.radioButtonInchingModeSingle.Location = new System.Drawing.Point(10, 46);
            this.radioButtonInchingModeSingle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButtonInchingModeSingle.Name = "radioButtonInchingModeSingle";
            this.radioButtonInchingModeSingle.Size = new System.Drawing.Size(140, 33);
            this.radioButtonInchingModeSingle.TabIndex = 7;
            this.radioButtonInchingModeSingle.TabStop = true;
            this.radioButtonInchingModeSingle.Text = "單次動作";
            this.radioButtonInchingModeSingle.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 5;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.Controls.Add(this.button_inching_negative_z, 4, 2);
            this.tableLayoutPanel11.Controls.Add(this.button_inching_positive_z, 4, 0);
            this.tableLayoutPanel11.Controls.Add(this.button_inching_negative_y, 1, 2);
            this.tableLayoutPanel11.Controls.Add(this.button_inching_positive_x, 2, 1);
            this.tableLayoutPanel11.Controls.Add(this.button_inching_negative_x, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.button_inching_positive_y, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.numericUpDown_inching_z, 4, 1);
            this.tableLayoutPanel11.Controls.Add(this.numericUpDown_inching_xy, 1, 1);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(72, 72);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(868, 478);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // button_inching_negative_z
            // 
            this.button_inching_negative_z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_inching_negative_z.Location = new System.Drawing.Point(697, 357);
            this.button_inching_negative_z.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_inching_negative_z.Name = "button_inching_negative_z";
            this.button_inching_negative_z.Size = new System.Drawing.Size(166, 81);
            this.button_inching_negative_z.TabIndex = 0;
            this.button_inching_negative_z.Text = "Z-";
            this.button_inching_negative_z.UseVisualStyleBackColor = true;
            this.button_inching_negative_z.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_inching_negative_z_MouseDown);
            this.button_inching_negative_z.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_inching_negative_z_MouseUp);
            // 
            // button_inching_positive_z
            // 
            this.button_inching_positive_z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_inching_positive_z.Location = new System.Drawing.Point(697, 39);
            this.button_inching_positive_z.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_inching_positive_z.Name = "button_inching_positive_z";
            this.button_inching_positive_z.Size = new System.Drawing.Size(166, 81);
            this.button_inching_positive_z.TabIndex = 0;
            this.button_inching_positive_z.Text = "Z+";
            this.button_inching_positive_z.UseVisualStyleBackColor = true;
            this.button_inching_positive_z.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_inching_positive_z_MouseDown);
            this.button_inching_positive_z.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_inching_positive_z_MouseUp);
            // 
            // button_inching_negative_y
            // 
            this.button_inching_negative_y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_inching_negative_y.Location = new System.Drawing.Point(178, 357);
            this.button_inching_negative_y.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_inching_negative_y.Name = "button_inching_negative_y";
            this.button_inching_negative_y.Size = new System.Drawing.Size(163, 81);
            this.button_inching_negative_y.TabIndex = 0;
            this.button_inching_negative_y.Text = "Y-";
            this.button_inching_negative_y.UseVisualStyleBackColor = true;
            this.button_inching_negative_y.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_inching_negative_y_MouseDown);
            this.button_inching_negative_y.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_inching_negative_y_MouseUp);
            // 
            // button_inching_positive_x
            // 
            this.button_inching_positive_x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_inching_positive_x.Location = new System.Drawing.Point(351, 198);
            this.button_inching_positive_x.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_inching_positive_x.Name = "button_inching_positive_x";
            this.button_inching_positive_x.Size = new System.Drawing.Size(163, 81);
            this.button_inching_positive_x.TabIndex = 0;
            this.button_inching_positive_x.Text = "X+";
            this.button_inching_positive_x.UseVisualStyleBackColor = true;
            this.button_inching_positive_x.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_inching_positive_x_MouseDown);
            this.button_inching_positive_x.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_inching_positive_x_MouseUp);
            // 
            // button_inching_negative_x
            // 
            this.button_inching_negative_x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_inching_negative_x.Location = new System.Drawing.Point(5, 198);
            this.button_inching_negative_x.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_inching_negative_x.Name = "button_inching_negative_x";
            this.button_inching_negative_x.Size = new System.Drawing.Size(163, 81);
            this.button_inching_negative_x.TabIndex = 0;
            this.button_inching_negative_x.Text = "X-";
            this.button_inching_negative_x.UseVisualStyleBackColor = true;
            this.button_inching_negative_x.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_inching_negative_x_MouseDown);
            this.button_inching_negative_x.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_inching_negative_x_MouseUp);
            // 
            // button_inching_positive_y
            // 
            this.button_inching_positive_y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_inching_positive_y.Location = new System.Drawing.Point(178, 39);
            this.button_inching_positive_y.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_inching_positive_y.Name = "button_inching_positive_y";
            this.button_inching_positive_y.Size = new System.Drawing.Size(163, 81);
            this.button_inching_positive_y.TabIndex = 0;
            this.button_inching_positive_y.Text = "Y+";
            this.button_inching_positive_y.UseVisualStyleBackColor = true;
            this.button_inching_positive_y.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_inching_positive_y_MouseDown);
            this.button_inching_positive_y.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_inching_positive_y_MouseUp);
            // 
            // numericUpDown_inching_z
            // 
            this.numericUpDown_inching_z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_inching_z.DecimalPlaces = 3;
            this.numericUpDown_inching_z.Location = new System.Drawing.Point(697, 221);
            this.numericUpDown_inching_z.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown_inching_z.Name = "numericUpDown_inching_z";
            this.numericUpDown_inching_z.Size = new System.Drawing.Size(166, 35);
            this.numericUpDown_inching_z.TabIndex = 1;
            this.numericUpDown_inching_z.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown_inching_xy
            // 
            this.numericUpDown_inching_xy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_inching_xy.DecimalPlaces = 3;
            this.numericUpDown_inching_xy.Location = new System.Drawing.Point(178, 221);
            this.numericUpDown_inching_xy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown_inching_xy.Name = "numericUpDown_inching_xy";
            this.numericUpDown_inching_xy.Size = new System.Drawing.Size(163, 35);
            this.numericUpDown_inching_xy.TabIndex = 1;
            this.numericUpDown_inching_xy.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tabPage_sub_camera
            // 
            this.tabPage_sub_camera.Controls.Add(this.tableLayoutPanel12);
            this.tabPage_sub_camera.Location = new System.Drawing.Point(10, 47);
            this.tabPage_sub_camera.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage_sub_camera.Name = "tabPage_sub_camera";
            this.tabPage_sub_camera.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage_sub_camera.Size = new System.Drawing.Size(1146, 856);
            this.tabPage_sub_camera.TabIndex = 3;
            this.tabPage_sub_camera.Text = "攝影機";
            this.tabPage_sub_camera.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.pictureBox_camera, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(5, 6);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(1136, 844);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 3;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.Controls.Add(this.checkBox_camera_freerun, 2, 1);
            this.tableLayoutPanel13.Controls.Add(this.button_camera_open, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.button_camera_setting, 1, 1);
            this.tableLayoutPanel13.Controls.Add(this.button_camera_close, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.button_camera_choose, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.button_camera_snapshot, 2, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(5, 639);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(1126, 199);
            this.tableLayoutPanel13.TabIndex = 7;
            // 
            // checkBox_camera_freerun
            // 
            this.checkBox_camera_freerun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_camera_freerun.AutoSize = true;
            this.checkBox_camera_freerun.Checked = true;
            this.checkBox_camera_freerun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_camera_freerun.Location = new System.Drawing.Point(755, 132);
            this.checkBox_camera_freerun.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkBox_camera_freerun.Name = "checkBox_camera_freerun";
            this.checkBox_camera_freerun.Size = new System.Drawing.Size(366, 33);
            this.checkBox_camera_freerun.TabIndex = 8;
            this.checkBox_camera_freerun.Text = "Free Run";
            this.checkBox_camera_freerun.UseVisualStyleBackColor = true;
            // 
            // button_camera_open
            // 
            this.button_camera_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_camera_open.Location = new System.Drawing.Point(5, 20);
            this.button_camera_open.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_camera_open.Name = "button_camera_open";
            this.button_camera_open.Size = new System.Drawing.Size(365, 58);
            this.button_camera_open.TabIndex = 8;
            this.button_camera_open.Text = "開啟";
            this.button_camera_open.UseVisualStyleBackColor = true;
            // 
            // button_camera_setting
            // 
            this.button_camera_setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_camera_setting.Location = new System.Drawing.Point(380, 120);
            this.button_camera_setting.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_camera_setting.Name = "button_camera_setting";
            this.button_camera_setting.Size = new System.Drawing.Size(365, 58);
            this.button_camera_setting.TabIndex = 8;
            this.button_camera_setting.Text = "設定";
            this.button_camera_setting.UseVisualStyleBackColor = true;
            // 
            // button_camera_close
            // 
            this.button_camera_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_camera_close.Location = new System.Drawing.Point(5, 120);
            this.button_camera_close.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_camera_close.Name = "button_camera_close";
            this.button_camera_close.Size = new System.Drawing.Size(365, 58);
            this.button_camera_close.TabIndex = 7;
            this.button_camera_close.Text = "關閉";
            this.button_camera_close.UseVisualStyleBackColor = true;
            // 
            // button_camera_choose
            // 
            this.button_camera_choose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_camera_choose.Location = new System.Drawing.Point(380, 20);
            this.button_camera_choose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_camera_choose.Name = "button_camera_choose";
            this.button_camera_choose.Size = new System.Drawing.Size(365, 58);
            this.button_camera_choose.TabIndex = 8;
            this.button_camera_choose.Text = "選擇";
            this.button_camera_choose.UseVisualStyleBackColor = true;
            // 
            // button_camera_snapshot
            // 
            this.button_camera_snapshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_camera_snapshot.Location = new System.Drawing.Point(755, 20);
            this.button_camera_snapshot.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_camera_snapshot.Name = "button_camera_snapshot";
            this.button_camera_snapshot.Size = new System.Drawing.Size(366, 58);
            this.button_camera_snapshot.TabIndex = 8;
            this.button_camera_snapshot.Text = "快照";
            this.button_camera_snapshot.UseVisualStyleBackColor = true;
            // 
            // pictureBox_camera
            // 
            this.pictureBox_camera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_camera.Location = new System.Drawing.Point(5, 6);
            this.pictureBox_camera.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox_camera.Name = "pictureBox_camera";
            this.pictureBox_camera.Size = new System.Drawing.Size(1126, 621);
            this.pictureBox_camera.TabIndex = 0;
            this.pictureBox_camera.TabStop = false;
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_basic_control);
            this.tabControl_main.Controls.Add(this.tabPage_exclusive_control);
            this.tabControl_main.Location = new System.Drawing.Point(21, 187);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(2561, 1101);
            this.tabControl_main.TabIndex = 7;
            // 
            // tabPage_basic_control
            // 
            this.tabPage_basic_control.Controls.Add(this.tabControl1);
            this.tabPage_basic_control.Controls.Add(this.tabControl_sub);
            this.tabPage_basic_control.Location = new System.Drawing.Point(10, 47);
            this.tabPage_basic_control.Name = "tabPage_basic_control";
            this.tabPage_basic_control.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_basic_control.Size = new System.Drawing.Size(2541, 1044);
            this.tabPage_basic_control.TabIndex = 0;
            this.tabPage_basic_control.Text = "基本";
            this.tabPage_basic_control.UseVisualStyleBackColor = true;
            // 
            // tabPage_exclusive_control
            // 
            this.tabPage_exclusive_control.Location = new System.Drawing.Point(10, 47);
            this.tabPage_exclusive_control.Name = "tabPage_exclusive_control";
            this.tabPage_exclusive_control.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_exclusive_control.Size = new System.Drawing.Size(2541, 1044);
            this.tabPage_exclusive_control.TabIndex = 1;
            this.tabPage_exclusive_control.Text = "專屬";
            this.tabPage_exclusive_control.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2606, 1313);
            this.Controls.Add(this.tabControl_main);
            this.Controls.Add(this.groupBox_connect_disconnect);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "Robotic Arm Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
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
            this.tabPage_sub_actionflow.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tabPage_sub_position_record.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.groupBox_position_record.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabPage_sub_inching.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inching_z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inching_xy)).EndInit();
            this.tabPage_sub_camera.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).EndInit();
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_basic_control.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton radioButton_position_type_absolute;
        private System.Windows.Forms.RadioButton radioButton_position_type_relative;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_coordinate_type_descartes;
        private System.Windows.Forms.RadioButton radioButton_coordinate_type_joint;
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
        private System.Windows.Forms.TabPage tabPage_sub_actionflow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button button_actionflow_do_selected;
        private System.Windows.Forms.ListView listView_actionflow_actions;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button button_actionflow_do_all;
        private System.Windows.Forms.CheckBox checkBox_actionflow_autoNext;
        private System.Windows.Forms.CheckBox checkBox_actionflow_showMsg;
        private System.Windows.Forms.TabPage tabPage_sub_inching;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button button_inching_positive_y;
        private System.Windows.Forms.Button button_inching_negative_z;
        private System.Windows.Forms.Button button_inching_positive_z;
        private System.Windows.Forms.Button button_inching_negative_y;
        private System.Windows.Forms.Button button_inching_positive_x;
        private System.Windows.Forms.Button button_inching_negative_x;
        private System.Windows.Forms.NumericUpDown numericUpDown_inching_z;
        private System.Windows.Forms.NumericUpDown numericUpDown_inching_xy;
        private System.Windows.Forms.TabPage tabPage_sub_camera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.PictureBox pictureBox_camera;
        private System.Windows.Forms.Button button_camera_close;
        private System.Windows.Forms.Button button_camera_open;
        private System.Windows.Forms.Button button_camera_setting;
        private System.Windows.Forms.Button button_camera_choose;
        private System.Windows.Forms.CheckBox checkBox_camera_freerun;
        private System.Windows.Forms.Button button_camera_snapshot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton radioButtonInchingModeContinuousWide;
        private System.Windows.Forms.RadioButton radioButtonInchingModeContinuousNarrow;
        private System.Windows.Forms.RadioButton radioButtonInchingModeSingle;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_basic_control;
        private System.Windows.Forms.TabPage tabPage_exclusive_control;
    }
}

