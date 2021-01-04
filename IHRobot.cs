using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using static SDKHrobot.HRobot;

namespace HiwinRobot
{
    public interface IHRobot
    {
        int circ_axis(int robot, int mode, double[] point_aux, double[] point_end);

        int circ_pos(int robot, int mode, double[] point_aux, double[] point_end);

        int circ_pr(int robot, int mode, int point_aux, int point_end);

        int clear_alarm(int robot);

        int confirm_home_point(int robot);

        int define_base(int robot, int index, [In] double[] data);

        int define_tool(int robot, int index, [In] double[] data);

        int delete_file(int robot, string FilePath);

        int delete_folder(int robot, string FilePath);

        void disconnect(int a);

        int download_file(int robot, string fromFilePath, string toFilePath);

        int enable_cart_soft_limit(int robot, bool enable);

        int enable_joint_soft_limit(int robot, bool enable);

        int ext_asyptp(int robot, int mode, double[] axis);

        int ext_lin_axis(int robot, int mode, double smooth_value, double[] axis);

        int ext_lin_pos(int robot, int mode, double smooth_value, double[] position);

        int ext_mastering(int robot, int index);

        int ext_ptp_axis(int robot, int mode, double[] axis);

        int ext_ptp_pos(int robot, int mode, double[] position);

        int ext_task_start(int robot, int mode, int select);

        int file_drag(int robot, string fromFilePath, string toFilePath);

        int file_rename(int robot, string oldFilePath, string newFilePath);

        int get_acc_dec_ratio(int robot);

        double get_acc_time(int robot);

        int get_alarm_code(int robot, [In, Out] ref int count, [Out] UInt64[] alarm_code);

        int get_base_data(int robot, int index, [In, Out] double[] data);

        int get_base_number(int robot);

        int get_cart_soft_limit_config(int robot, ref bool enable, double[] low_limit, double[] high_limit);

        int get_command_count(int robot);

        int get_command_id(int robot);

        int get_connection_level(int a);

        int get_controller_time(int robot, ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second);

        int get_counter(int robot, int index);

        int get_counter_name(int robot, int index, UInt16[] name, int arr_size);

        int get_current_ext_mode(int robot, StringBuilder mode);

        int get_current_ext_pos(int robot, double[] pos);

        int get_current_joint(int robot, [In, Out] double[] value);

        int get_current_position(int robot, [In, Out] double[] value);

        int get_current_rpm(int robot, [In, Out] double[] value);

        int get_device_born_date(int robot, int[] date);

        int get_DI_simulation_Enable(int robot, int index);

        int get_digital_input(int robot, int index);

        int get_digital_input_comment(int robot, int di_index, UInt16[] comment, int arr_size);

        int get_digital_output(int robot, int index);

        int get_digital_output_comment(int robot, int do_index, UInt16[] comment, int arr_size);

        int get_digital_setting(int robot, int[] index, StringBuilder text);

        int get_encoder_count(int robot, [In, Out] Int32[] value);

        int get_execute_file_name(int robot, StringBuilder file_name);

        int get_ext_axis_setting(int robot, int index, ref bool enable, ref int mode, ref double high_limit, ref double low_limit);

        int get_ext_axis_setting_advanced(int robot, int index, ref int type, ref bool couple, ref bool continuous, int[] int_data, double[] double_data);

        int get_ext_driver_limit(int robot, int index, ref bool enable, ref bool inverse, ref bool negative_num, ref bool positive_num, ref bool N_light, ref bool P_light);

        int get_ext_encoder(int robot, Int32[] EncCount);

        int get_ext_home_point(int robot, double[] ext_pos);

        int get_function_input(int robot, int index);

        int get_function_output(int robot, int index);

        int get_home_point(int robot, double[] joint);

        int get_home_warning_setting(int robot, double[] allow_error_value, double[] allow_near_home);

        int get_hrsdk_version(StringBuilder v);

        int get_hrss_mode(int robot);

        int get_hrss_version(int robot, StringBuilder value);

        int get_joint_soft_limit_config(int robot, ref bool enable, double[] low_limit, double[] high_limit);

        double get_lin_speed(int robot);

        int get_mileage(int robot, [In, Out] double[] value);

        int get_module_input_config(int robot, int index, ref bool sim, ref bool value, ref int type, ref int start, ref int end, UInt16[] comment, int arr_size);

        int get_module_output_config(int robot, int index, ref bool value, ref int type, ref int start, ref int end, UInt16[] comment, int arr_size);

        int get_motion_state(int robot);

        int get_motor_state(int robot);

        int get_motor_torque(int robot, [In, Out] double[] value);

        int get_network_config(int robot, [In, Out] ref int connect_type, StringBuilder ip_addr, [In, Out] ref int port, [In, Out] ref int bracket, [In, Out] ref int separator, [In, Out] ref bool is_format);

        int get_network_show_msg(int robot, ref int flag);

        int get_operation_mode(int robot);

        int get_operation_time(int robot, [In, Out] int[] value);

        int get_override_ratio(int robot);

        int get_payload_active(int robot, ref int index);

        int get_payload_config(int robot, int index, double[] value, StringBuilder comment);

        int get_pr(int robot, int pr_num, ref int pr_type, [In, Out] double[] coor, ref int tool, ref int _base);

        int get_pr_comment(int robot, int index, UInt16[] comment, int arr_size);

        int get_pr_coordinate(int robot, int index, [In, Out] double[] value);

        int get_pr_tool_base(int robot, int index, [In, Out] int[] value);

        int get_pr_type(int robot, int index);

        int get_previous_extpos(int robot, double[] ext_pos);

        int get_previous_pos(int robot, double[] joint);

        int get_prog_name(int robot, int file_index, StringBuilder file_name);

        int get_prog_number(int robot);

        int get_ptp_speed(int robot);

        int get_robot_id(int robot, StringBuilder value);

        int get_robot_info(int robot, int page_sel, int tool_num, int base_num, StringBuilder info, bool is_ready);

        int get_robot_input(int robot, int index);

        int get_robot_output(int robot, int index);

        int get_robot_type(int robot, StringBuilder value);

        int get_rsr_prog_name(int robot, int index, StringBuilder filename);

        int get_timer(int robot, int index);

        int get_timer_name(int robot, int index, UInt16[] name, int arr_size);

        int get_timer_status(int robot, int index);

        int get_tool_data(int robot, int index, [In, Out] double[] data);

        int get_tool_number(int robot);

        int get_total_mileage(int robot, [In, Out] double[] value);

        int get_user_alarm_setting_message(int robot, int number, StringBuilder message);

        int get_utilization(int robot, [In, Out] int[] value);

        int get_utilization_ratio(int robot, ref double ratio);

        int get_valve_output(int robot, int index);

        int jog(int robot, int type, int index, int dir);

        int jog_home(int robot);

        int jog_stop(int robot);

        int lin_axis(int robot, int mode, double smooth_value, double[] point);

        int lin_pos(int robot, int mode, double smooth_value, double[] point);

        int lin_pr(int robot, int mode, double smooth_value, int point);

        int lin_rel_axis(int robot, int mode, double smooth_value, double[] point);

        int lin_rel_pos(int robot, int mode, double smooth_value, double[] point);

        int motion_abort(int robot);

        int motion_continue(int robot);

        int motion_delay(int robot, int delay);

        int motion_hold(int robot);

        int network_change_ip(int robot, int lan_index, int ip_type, StringBuilder ip_addr);

        int network_connect(int robot);

        int network_disconnect(int robot);

        int network_get_state(int robot);

        int network_recieve_msg(int robot, StringBuilder msg);

        int network_send_msg(int robot, StringBuilder msg);

        int new_folder(int robot, string FilePath);

        int open_connection(String a, int mode, CallBackFun func);

        int ptp_axis(int robot, int mode, double[] point);

        int ptp_pos(int robot, int mode, double[] point);

        int ptp_pr(int robot, int mode, int point);

        int ptp_rel_axis(int robot, int mode, double[] point);

        int ptp_rel_pos(int robot, int mode, double[] point);

        int remove_command(int robot, int num);

        int remove_command_tail(int robot, int num);

        int remove_pr(int robot, int pr_num);

        int remove_rsr(int robot, int index);

        int save_module_io_setting(int robot);

        int send_file(int robot, string path, string to_file_path);

        int set_acc_dec_ratio(int robot, int v);

        int set_acc_time(int robot, double value);

        int set_base_number(int robot, int index);

        int set_cart_soft_limit(int robot, double[] low_limit, double[] high_limit);

        int set_command_id(int robot, int num);

        int set_connection_level(int robot, int mode);

        int set_counter(int robot, int index, int value);

        int set_counter_name(int robot, int index, UInt16[] name);

        int set_DI_simulation(int robot, int index, bool On_Off);

        int set_DI_simulation_Enable(int robot, int index, bool On_Off);

        int set_digital_input_comment(int robot, int di_index, UInt16[] comment);

        int set_digital_output(int robot, int index, bool On_Off);

        int set_digital_output_comment(int robot, int do_index, UInt16[] comment);

        int set_digital_setting(int robot, int[] index, StringBuilder text);

        int set_ext_axis_setting(int robot, int index, bool enable, int mode, double high_limit, double low_limit);

        int set_ext_axis_setting_advanced(int robot, int index, int type, bool couple, bool continuous, int[] int_data, double[] double_data);

        int set_ext_driver_limit(int robot, int index, bool enable, bool inverse, int negative_num, int positive_num);

        int set_ext_home_point(int robot, double[] ext_pos);

        int set_home_point(int robot, double[] joint);

        int set_home_warning_setting(int robot, double[] allow_error_value, double[] allow_near_home);

        int set_joint_soft_limit(int robot, double[] low_limit, double[] high_limit);

        int set_language(int robot, int language_number);

        int set_lin_speed(int robot, double v);

        int set_module_input_comment(int robot, int index, UInt16[] comment);

        int set_module_input_end(int robot, int index, int end_number);

        int set_module_input_simulation(int robot, int index, bool enable);

        int set_module_input_start(int robot, int index, int start_number);

        int set_module_input_type(int robot, int index, int type);

        int set_module_input_value(int robot, int index, bool enable);

        int set_module_output_comment(int robot, int index, UInt16[] comment);

        int set_module_output_end(int robot, int index, int end_number);

        int set_module_output_start(int robot, int index, int start_number);

        int set_module_output_type(int robot, int index, int type);

        int set_module_output_value(int robot, int index, bool enable);

        int set_motor_state(int robot, int onOff);

        int set_network_config(int robot, [In] int connect_type, StringBuilder ip_addr, [In] int port, [In] int bracket, [In] int separator, [In] bool is_format);

        int set_network_show_msg(int robot, int enable);

        int set_operation_mode(int robot, int mode);

        int set_override_ratio(int robot, int v);

        int set_payload_active(int robot, int index);

        int set_payload_config(int robot, int index, double[] value, StringBuilder comment);

        int set_pr(int robot, int pr_num, int pr_type, [In, Out] double[] coor, int tool, int _base);

        int set_pr_comment(int robot, int index, UInt16[] comment);

        int set_pr_coordinate(int robot, int index, double[] value);

        int set_pr_tool_base(int robot, int index, [In] int tool, int _base);

        int set_pr_type(int robot, int index, int value);

        int set_ptp_speed(int robot, int v);

        int set_robot_id(int robot, StringBuilder value);

        int set_robot_output(int robot, int index, bool On_Off);

        int set_rsr(int robot, StringBuilder filename, int index);

        int set_smooth_length(int robot, double radius);

        int set_timer(int robot, int index, int value);

        int set_timer_name(int robot, int index, UInt16[] name);

        int set_timer_start(int robot, int index);

        int set_timer_stop(int robot, int index);

        int set_tool_number(int robot, int index);

        int set_user_alarm_setting_message(int robot, int number, StringBuilder message);

        int set_valve_output(int robot, int index, bool On_Off);

        int SyncOutput(int robot, int type, int id, int on_off, int synMode, int delay, int distance);

        int task_abort(int robot);

        int task_continue(int robot);

        int task_hold(int robot);

        int task_start(int robot, string name);

        int update_hrss(int robot, StringBuilder path);
    }
}