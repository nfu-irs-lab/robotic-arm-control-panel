using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SDKHrobot
{
    internal enum CartesianCoordinates
    {
        kCartesianX = 0,
        kCartesianY,
        kCartesianZ,
        kCartesianA,
        kCartesianB,
        kCartesianC
    };

    internal enum ConnectionLevels
    {
        kDisconnection = -1,
        kMonitor = 0,
        kController
    };

    internal enum HrssMode
    {
        AUTO = 1,
        T2 = 2,
        EXT = 3,
        T1 = 0,
    };

    internal enum JointCoordinates
    {
        kJoint1 = 0,
        kJoint2,
        kJoint3,
        kJoint4,
        kJoint5,
        kJoint6
    };

    internal enum OperationModes
    {
        kManual = 0,
        kAuto
    };

    internal enum RobotMotionStatus
    {
        kIdle = 1,
        kRunning,
        kHold,
        kDelay,
        kWait
    };

    internal enum SpaceOperationDirection
    {
        kPositive = 1,
        kNegative = -1,
    };

    internal enum SpaceOperationTypes
    {
        kCartesian = 0,
        kJoint,
        kTool
    };

    public static class GlobalIndex
    {
        public static int callback_index = 0;
    }

    public static class GlobalWord
    {
        public enum Word
        {
            A = 65,
            Z = 90,
            _ = 95,
            a = 97,
            z = 122,
        };
    }

    public class Global
    {
        public enum File_text_type
        {
            folder = -1,
            Main_pro,
            Sub_pro,
            Function_pro,
        };

        public enum File_type
        {
            folder,
            file,
        };

        public enum FileLocation
        {
            Location,
            Controller,
        };

        public enum Master
        {
            kZero_position = 0,
            kCalibration,
        };

        public enum SetConnectControl
        {
            SetConnected,
            SetAll,
        };

        private static readonly object Mutex = new object();
        private static volatile Global _instance;

        private Global()
        { }

        public static Global Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Mutex)
                    {
                        if (_instance == null)
                        {
                            _instance = new Global();
                        }
                    }
                }
                return _instance;
            }
        }
    }

    public class HRobot
    {
        // will send message from Hiwin Controller
        public delegate void CallBackFun(UInt16 cmd, UInt16 rlt, ref UInt16 Msg, int len);

        [DllImport("HRSDK.dll")]
        public static extern int circ_axis(int robot, int mode, double[] point_aux, double[] point_end);

        [DllImport("HRSDK.dll")]
        public static extern int circ_pos(int robot, int mode, double[] point_aux, double[] point_end);

        [DllImport("HRSDK.dll")]
        public static extern int circ_pr(int robot, int mode, int point_aux, int point_end);

        [DllImport("HRSDK.dll")]
        public static extern int clear_alarm(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int confirm_home_point(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int define_base(int robot, int index, [In] double[] data);

        [DllImport("HRSDK.dll")]
        public static extern int define_tool(int robot, int index, [In] double[] data);

        [DllImport("HRSDK.dll")]
        public static extern int delete_file(int robot, string FilePath);

        [DllImport("HRSDK.dll")]
        public static extern int delete_folder(int robot, string FilePath);

        [DllImport("HRSDK.dll")]
        public static extern void disconnect(int a);

        [DllImport("HRSDK.dll")]
        public static extern int download_file(int robot, string fromFilePath, string toFilePath);

        [DllImport("HRSDK.dll")]
        public static extern int enable_cart_soft_limit(int robot, bool enable);

        [DllImport("HRSDK.dll")]
        public static extern int enable_joint_soft_limit(int robot, bool enable);

        [DllImport("HRSDK.dll")]
        public static extern int ext_asyptp(int robot, int mode, double[] axis);

        [DllImport("HRSDK.dll")]
        public static extern int ext_lin_axis(int robot, int mode, double smooth_value, double[] axis);

        [DllImport("HRSDK.dll")]
        public static extern int ext_lin_pos(int robot, int mode, double smooth_value, double[] position);

        [DllImport("HRSDK.dll")]
        public static extern int ext_mastering(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int ext_ptp_axis(int robot, int mode, double[] axis);

        [DllImport("HRSDK.dll")]
        public static extern int ext_ptp_pos(int robot, int mode, double[] position);

        [DllImport("HRSDK.dll")]
        public static extern int ext_task_start(int robot, int mode, int select);

        [DllImport("HRSDK.dll")]
        public static extern int file_drag(int robot, string fromFilePath, string toFilePath);

        [DllImport("HRSDK.dll")]
        public static extern int file_rename(int robot, string oldFilePath, string newFilePath);

        [DllImport("HRSDK.dll")]
        public static extern int get_acc_dec_ratio(int robot);

        [DllImport("HRSDK.dll")]
        public static extern double get_acc_time(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int get_alarm_code(int robot, [In, Out] ref int count, [Out] UInt64[] alarm_code);

        [DllImport("HRSDK.dll")]
        public static extern int get_base_data(int robot, int index, [In, Out] double[] data);

        [DllImport("HRSDK.dll")]
        public static extern int get_base_number(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int get_cart_soft_limit_config(int robot, ref bool enable, double[] low_limit, double[] high_limit);

        [DllImport("HRSDK.dll")]
        public static extern int get_command_count(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int get_command_id(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int get_connection_level(int a);

        [DllImport("HRSDK.dll")]
        public static extern int get_controller_time(int robot,
                                                     ref int year,
                                                     ref int month,
                                                     ref int day,
                                                     ref int hour,
                                                     ref int minute,
                                                     ref int second);

        [DllImport("HRSDK.dll")]
        public static extern int get_counter(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int get_counter_name(int robot, int index, UInt16[] name, int arr_size);

        [DllImport("HRSDK.dll")]
        public static extern int get_current_ext_mode(int robot, StringBuilder mode);

        [DllImport("HRSDK.dll")]
        public static extern int get_current_ext_pos(int robot, double[] pos);

        [DllImport("HRSDK.dll")]
        public static extern int get_current_joint(int robot, [In, Out] double[] value);

        [DllImport("HRSDK.dll")]
        public static extern int get_current_position(int robot, [In, Out] double[] value);

        [DllImport("HRSDK.dll")]
        public static extern int get_current_rpm(int robot, [In, Out] double[] value);

        [DllImport("HRSDK.dll")]
        public static extern int get_device_born_date(int robot, int[] date);

        [DllImport("HRSDK.dll")]
        public static extern int get_DI_simulation_Enable(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int get_digital_input(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int get_digital_input_comment(int robot, int di_index, UInt16[] comment, int arr_size);

        [DllImport("HRSDK.dll")]
        public static extern int get_digital_output(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int get_digital_output_comment(int robot, int do_index, UInt16[] comment, int arr_size);

        [DllImport("HRSDK.dll")]
        public static extern int get_digital_setting(int robot, int[] index, StringBuilder text);

        [DllImport("HRSDK.dll")]
        public static extern int get_encoder_count(int robot, [In, Out] Int32[] value);

        [DllImport("HRSDK.dll")]
        public static extern int get_execute_file_name(int robot, StringBuilder file_name);

        [DllImport("HRSDK.dll")]
        public static extern int get_ext_axis_setting(int robot,
                                                      int index,
                                                      ref bool enable,
                                                      ref int mode,
                                                      ref double high_limit,
                                                      ref double low_limit);

        [DllImport("HRSDK.dll")]
        public static extern int get_ext_axis_setting_advanced(int robot,
                                                               int index,
                                                               ref int type,
                                                               ref bool couple,
                                                               ref bool continuous,
                                                               int[] int_data,
                                                               double[] double_data);

        [DllImport("HRSDK.dll")]
        public static extern int get_ext_driver_limit(int robot,
                                                      int index,
                                                      ref bool enable,
                                                      ref bool inverse,
                                                      ref bool negative_num,
                                                      ref bool positive_num,
                                                      ref bool N_light,
                                                      ref bool P_light);

        [DllImport("HRSDK.dll")]
        public static extern int get_ext_encoder(int robot, Int32[] EncCount);

        [DllImport("HRSDK.dll")]
        public static extern int get_ext_home_point(int robot, double[] ext_pos);

        [DllImport("HRSDK.dll")]
        public static extern int get_function_input(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int get_function_output(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int get_home_point(int robot, double[] joint);

        [DllImport("HRSDK.dll")]
        public static extern int get_home_warning_setting(int robot, double[] allow_error_value, double[] allow_near_home);

        [DllImport("HRSDK.dll")]
        public static extern int get_hrsdk_version(StringBuilder v);

        [DllImport("HRSDK.dll")]
        public static extern int get_hrss_mode(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int get_hrss_version(int robot, StringBuilder value);

        [DllImport("HRSDK.dll")]
        public static extern int get_joint_soft_limit_config(int robot, ref bool enable, double[] low_limit, double[] high_limit);

        [DllImport("HRSDK.dll")]
        public static extern double get_lin_speed(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int get_mileage(int robot, [In, Out] double[] value);

        [DllImport("HRSDK.dll")]
        public static extern int get_module_input_config(int robot,
                                                         int index,
                                                         ref bool sim,
                                                         ref bool value,
                                                         ref int type,
                                                         ref int start,
                                                         ref int end,
                                                         UInt16[] comment,
                                                         int arr_size);

        [DllImport("HRSDK.dll")]
        public static extern int get_module_output_config(int robot,
                                                          int index,
                                                          ref bool value,
                                                          ref int type,
                                                          ref int start,
                                                          ref int end,
                                                          UInt16[] comment,
                                                          int arr_size);

        [DllImport("HRSDK.dll")]
        public static extern int get_motion_state(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int get_motor_state(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int get_motor_torque(int robot, [In, Out] double[] value);

        [DllImport("HRSDK.dll")]
        public static extern int get_network_config(int robot,
                                                    [In, Out] ref int connect_type,
                                                    StringBuilder ip_addr,
                                                    [In, Out] ref int port,
                                                    [In, Out] ref int bracket,
                                                    [In, Out] ref int separator,
                                                    [In, Out] ref bool is_format);

        [DllImport("HRSDK.dll")]
        public static extern int get_network_show_msg(int robot, ref int flag);

        [DllImport("HRSDK.dll")]
        public static extern int get_operation_mode(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int get_operation_time(int robot, [In, Out] int[] value);

        [DllImport("HRSDK.dll")]
        public static extern int get_override_ratio(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int get_payload_active(int robot, ref int index);

        [DllImport("HRSDK.dll")]
        public static extern int get_payload_config(int robot, int index, double[] value, StringBuilder comment);

        [DllImport("HRSDK.dll")]
        public static extern int get_pr(int robot,
                                        int pr_num,
                                        ref int pr_type,
                                        [In, Out] double[] coor,
                                        ref int tool,
                                        ref int _base);

        [DllImport("HRSDK.dll")]
        public static extern int get_pr_comment(int robot, int index, UInt16[] comment, int arr_size);

        [DllImport("HRSDK.dll")]
        public static extern int get_pr_coordinate(int robot, int index, [In, Out] double[] value);

        [DllImport("HRSDK.dll")]
        public static extern int get_pr_tool_base(int robot, int index, [In, Out] int[] value);

        [DllImport("HRSDK.dll")]
        public static extern int get_pr_type(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int get_previous_extpos(int robot, double[] ext_pos);

        [DllImport("HRSDK.dll")]
        public static extern int get_previous_pos(int robot, double[] joint);

        [DllImport("HRSDK.dll")]
        public static extern int get_prog_name(int robot, int file_index, StringBuilder file_name);

        [DllImport("HRSDK.dll")]
        public static extern int get_prog_number(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int get_ptp_speed(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int get_robot_id(int robot, StringBuilder value);

        [DllImport("HRSDK.dll")]
        public static extern int get_robot_info(int robot,
                                                int page_sel,
                                                int tool_num,
                                                int base_num,
                                                StringBuilder info,
                                                bool is_ready);

        [DllImport("HRSDK.dll")]
        public static extern int get_robot_input(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int get_robot_output(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int get_robot_type(int robot, StringBuilder value);

        [DllImport("HRSDK.dll")]
        public static extern int get_rsr_prog_name(int robot, int index, StringBuilder filename);

        [DllImport("HRSDK.dll")]
        public static extern int get_timer(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int get_timer_name(int robot, int index, UInt16[] name, int arr_size);

        [DllImport("HRSDK.dll")]
        public static extern int get_timer_status(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int get_tool_data(int robot, int index, [In, Out] double[] data);

        [DllImport("HRSDK.dll")]
        public static extern int get_tool_number(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int get_total_mileage(int robot, [In, Out] double[] value);

        [DllImport("HRSDK.dll")]
        public static extern int get_user_alarm_setting_message(int robot, int number, StringBuilder message);

        [DllImport("HRSDK.dll")]
        public static extern int get_utilization(int robot, [In, Out] int[] value);

        [DllImport("HRSDK.dll")]
        public static extern int get_utilization_ratio(int robot, ref double ratio);

        [DllImport("HRSDK.dll")]
        public static extern int get_valve_output(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int jog(int robot, int type, int index, int dir);

        [DllImport("HRSDK.dll")]
        public static extern int jog_home(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int jog_stop(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int lin_axis(int robot, int mode, double smooth_value, double[] point);

        [DllImport("HRSDK.dll")]
        public static extern int lin_pos(int robot, int mode, double smooth_value, double[] point);

        [DllImport("HRSDK.dll")]
        public static extern int lin_pr(int robot, int mode, double smooth_value, int point);

        [DllImport("HRSDK.dll")]
        public static extern int lin_rel_axis(int robot, int mode, double smooth_value, double[] point);

        [DllImport("HRSDK.dll")]
        public static extern int lin_rel_pos(int robot, int mode, double smooth_value, double[] point);

        [DllImport("HRSDK.dll")]
        public static extern int motion_abort(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int motion_continue(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int motion_delay(int robot, int delay);

        [DllImport("HRSDK.dll")]
        public static extern int motion_hold(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int network_change_ip(int robot, int lan_index, int ip_type, StringBuilder ip_addr);

        [DllImport("HRSDK.dll")]
        public static extern int network_connect(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int network_disconnect(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int network_get_state(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int network_recieve_msg(int robot, StringBuilder msg);

        [DllImport("HRSDK.dll")]
        public static extern int network_send_msg(int robot, StringBuilder msg);

        [DllImport("HRSDK.dll")]
        public static extern int new_folder(int robot, string FilePath);

        [DllImport("HRSDK.dll")]
        public static extern int open_connection(String a, int mode, CallBackFun func);

        [DllImport("HRSDK.dll")]
        public static extern int ptp_axis(int robot, int mode, double[] point);

        [DllImport("HRSDK.dll")]
        public static extern int ptp_pos(int robot, int mode, double[] point);

        [DllImport("HRSDK.dll")]
        public static extern int ptp_pr(int robot, int mode, int point);

        [DllImport("HRSDK.dll")]
        public static extern int ptp_rel_axis(int robot, int mode, double[] point);

        [DllImport("HRSDK.dll")]
        public static extern int ptp_rel_pos(int robot, int mode, double[] point);

        [DllImport("HRSDK.dll")]
        public static extern int remove_command(int robot, int num);

        [DllImport("HRSDK.dll")]
        public static extern int remove_command_tail(int robot, int num);

        [DllImport("HRSDK.dll")]
        public static extern int remove_pr(int robot, int pr_num);

        [DllImport("HRSDK.dll")]
        public static extern int remove_rsr(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int save_module_io_setting(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int send_file(int robot, string path, string to_file_path);

        [DllImport("HRSDK.dll")]
        public static extern int set_acc_dec_ratio(int robot, int v);

        [DllImport("HRSDK.dll")]
        public static extern int set_acc_time(int robot, double value);

        [DllImport("HRSDK.dll")]
        public static extern int set_base_number(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int set_cart_soft_limit(int robot, double[] low_limit, double[] high_limit);

        [DllImport("HRSDK.dll")]
        public static extern int set_command_id(int robot, int num);

        [DllImport("HRSDK.dll")]
        public static extern int set_connection_level(int robot, int mode);

        [DllImport("HRSDK.dll")]
        public static extern int set_counter(int robot, int index, int value);

        [DllImport("HRSDK.dll")]
        public static extern int set_counter_name(int robot, int index, UInt16[] name);

        [DllImport("HRSDK.dll")]
        public static extern int set_DI_simulation(int robot, int index, bool On_Off);

        [DllImport("HRSDK.dll")]
        public static extern int set_DI_simulation_Enable(int robot, int index, bool On_Off);

        [DllImport("HRSDK.dll")]
        public static extern int set_digital_input_comment(int robot, int di_index, UInt16[] comment);

        [DllImport("HRSDK.dll")]
        public static extern int set_digital_output(int robot, int index, bool On_Off);

        [DllImport("HRSDK.dll")]
        public static extern int set_digital_output_comment(int robot, int do_index, UInt16[] comment);

        [DllImport("HRSDK.dll")]
        public static extern int set_digital_setting(int robot, int[] index, StringBuilder text);

        [DllImport("HRSDK.dll")]
        public static extern int set_ext_axis_setting(int robot,
                                                      int index,
                                                      bool enable,
                                                      int mode,
                                                      double high_limit,
                                                      double low_limit);

        [DllImport("HRSDK.dll")]
        public static extern int set_ext_axis_setting_advanced(int robot,
                                                               int index,
                                                               int type,
                                                               bool couple,
                                                               bool continuous,
                                                               int[] int_data,
                                                               double[] double_data);

        [DllImport("HRSDK.dll")]
        public static extern int set_ext_driver_limit(int robot,
                                                      int index,
                                                      bool enable,
                                                      bool inverse,
                                                      int negative_num,
                                                      int positive_num);

        [DllImport("HRSDK.dll")]
        public static extern int set_ext_home_point(int robot, double[] ext_pos);

        [DllImport("HRSDK.dll")]
        public static extern int set_home_point(int robot, double[] joint);

        [DllImport("HRSDK.dll")]
        public static extern int set_home_warning_setting(int robot, double[] allow_error_value, double[] allow_near_home);

        [DllImport("HRSDK.dll")]
        public static extern int set_joint_soft_limit(int robot, double[] low_limit, double[] high_limit);

        [DllImport("HRSDK.dll")]
        public static extern int set_language(int robot, int language_number);

        [DllImport("HRSDK.dll")]
        public static extern int set_lin_speed(int robot, double v);

        [DllImport("HRSDK.dll")]
        public static extern int set_module_input_comment(int robot, int index, UInt16[] comment);

        [DllImport("HRSDK.dll")]
        public static extern int set_module_input_end(int robot, int index, int end_number);

        [DllImport("HRSDK.dll")]
        public static extern int set_module_input_simulation(int robot, int index, bool enable);

        [DllImport("HRSDK.dll")]
        public static extern int set_module_input_start(int robot, int index, int start_number);

        [DllImport("HRSDK.dll")]
        public static extern int set_module_input_type(int robot, int index, int type);

        [DllImport("HRSDK.dll")]
        public static extern int set_module_input_value(int robot, int index, bool enable);

        [DllImport("HRSDK.dll")]
        public static extern int set_module_output_comment(int robot, int index, UInt16[] comment);

        [DllImport("HRSDK.dll")]
        public static extern int set_module_output_end(int robot, int index, int end_number);

        [DllImport("HRSDK.dll")]
        public static extern int set_module_output_start(int robot, int index, int start_number);

        [DllImport("HRSDK.dll")]
        public static extern int set_module_output_type(int robot, int index, int type);

        [DllImport("HRSDK.dll")]
        public static extern int set_module_output_value(int robot, int index, bool enable);

        [DllImport("HRSDK.dll")]
        public static extern int set_motor_state(int robot, int onOff);

        [DllImport("HRSDK.dll")]
        public static extern int set_network_config(int robot,
                                                    [In] int connect_type,
                                                    StringBuilder ip_addr,
                                                    [In] int port,
                                                    [In] int bracket,
                                                    [In] int separator,
                                                    [In] bool is_format);

        [DllImport("HRSDK.dll")]
        public static extern int set_network_show_msg(int robot, int enable);

        [DllImport("HRSDK.dll")]
        public static extern int set_operation_mode(int robot, int mode);

        [DllImport("HRSDK.dll")]
        public static extern int set_override_ratio(int robot, int v);

        [DllImport("HRSDK.dll")]
        public static extern int set_payload_active(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int set_payload_config(int robot, int index, double[] value, StringBuilder comment);

        [DllImport("HRSDK.dll")]
        public static extern int set_pr(int robot,
                                        int pr_num,
                                        int pr_type,
                                        [In, Out] double[] coor,
                                        int tool,
                                        int _base);

        [DllImport("HRSDK.dll")]
        public static extern int set_pr_comment(int robot, int index, UInt16[] comment);

        [DllImport("HRSDK.dll")]
        public static extern int set_pr_coordinate(int robot, int index, double[] value);

        [DllImport("HRSDK.dll")]
        public static extern int set_pr_tool_base(int robot, int index, [In] int tool, int _base);

        [DllImport("HRSDK.dll")]
        public static extern int set_pr_type(int robot, int index, int value);

        [DllImport("HRSDK.dll")]
        public static extern int set_ptp_speed(int robot, int v);

        [DllImport("HRSDK.dll")]
        public static extern int set_robot_id(int robot, StringBuilder value);

        [DllImport("HRSDK.dll")]
        public static extern int set_robot_output(int robot, int index, bool On_Off);

        [DllImport("HRSDK.dll")]
        public static extern int set_rsr(int robot, StringBuilder filename, int index);

        [DllImport("HRSDK.dll")]
        public static extern int set_smooth_length(int robot, double radius);

        [DllImport("HRSDK.dll")]
        public static extern int set_timer(int robot, int index, int value);

        [DllImport("HRSDK.dll")]
        public static extern int set_timer_name(int robot, int index, UInt16[] name);

        [DllImport("HRSDK.dll")]
        public static extern int set_timer_start(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int set_timer_stop(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int set_tool_number(int robot, int index);

        [DllImport("HRSDK.dll")]
        public static extern int set_user_alarm_setting_message(int robot, int number, StringBuilder message);

        [DllImport("HRSDK.dll")]
        public static extern int set_valve_output(int robot, int index, bool On_Off);

        [DllImport("HRSDK.dll")]
        public static extern int SyncOutput(int robot,
                                            int type,
                                            int id,
                                            int on_off,
                                            int synMode,
                                            int delay,
                                            int distance);

        [DllImport("HRSDK.dll")]
        public static extern int task_abort(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int task_continue(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int task_hold(int robot);

        [DllImport("HRSDK.dll")]
        public static extern int task_start(int robot, string name);

        [DllImport("HRSDK.dll")]
        public static extern int update_hrss(int robot, StringBuilder path);
    }
}