using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; // DllImport

namespace HIWIN_Robot
{
    /// <summary>
    /// HRSDK：上銀機器人開發套件。
    /// </summary>
    internal class HIWIN_Robot_SDK
    {
        #region --更新紀錄--

        /*
         * 2019.05.28 更新上銀SDK ("HRMB v1.0.0" 變更為 "HRSDK v2.1.7")
         */

        #endregion --更新紀錄--

        #region --命令清單--

        /* ├ 連線命令
         * │ ├ Connect:與裝置連線
         * │ ├ Close:關閉與裝置的連線
         * │ ├ get_HRSDK_version:取得HRSDK版本號
         * │ └ get_connection_level:取得連線等級
         * │
         * ├ 系統變數命令
         * │ ├ set_acc_dec_ratio:設定加速度比例
         * │ ├ get_acc_dec_ratio:取得加速度比例
         * │ ├ set_override_ratio:設定整體速度倍率
         * │ ├ get_override_ratio:取得整體速度倍率
         * │ └ get_alarm_code:取得警報代碼
         * │
         * ├ 控制器設定命令
         * │ ├ set_motor_state:伺服設定
         * │ ├ get_motor_state:取得伺服狀態
         * │ ├ speed_limit_on:安全限速功能開啟
         * │ ├ speed_limit_off:安全限速功能關閉
         * │ ├ get_speed_limit_state:取得安全限速功能狀態
         * │ └ clear_alarm:清除錯誤
         * │
         * ├ 運動命令
         * │ ├ 點對點運動
         * │ │ ├ ptp_pos:絕對座標位置點對點運動
         * │ │ └ ptp_axis:絕對關節角度點對點運動
         * │ ├ 直線運動
         * │ │ ├ lin_pos:絕對座標位置直線運動
         * │ │ └ lin_axis:絕對關節角度直線運動
         * │ └ 圓弧運動
         * │    └ circ_pos:絕對座標位置圓弧運動
         * │
         * └ 手臂資訊命令
         *    ├ get_current_joint:取得關節座標
         *    └ get_current_position:取得絕對座標
         */

        #endregion --命令清單--

        #region --新SDK HRSDK--

        //從上銀控制器發送消息
        public delegate void CallBackFun(UInt16 cmd, UInt16 rlt, ref UInt16 Msg, int len);

        #region --連線命令--

        //關閉與裝置連結
        [DllImport("HRSDK.dll")]
        public static extern void Close(int a);

        //裝置連線
        [DllImport("HRSDK.dll")]
        public static extern int Connect(String a, int mode, CallBackFun func);

        //取得連線等級
        [DllImport("HRSDK.dll")]
        public static extern int get_connection_level(int a);

        //取得HRSDK版本號
        [DllImport("HRSDK.dll")]
        public static extern int get_HRSDK_version(StringBuilder v);

        #endregion --連線命令--

        #region --系統變數命令--

        //取得加速度比例
        [DllImport("HRSDK.dll")]
        public static extern int get_acc_dec_ratio(int robot);

        //取得警報代碼
        [DllImport("HRSDK.dll")]
        public static extern int get_alarm_code(int robot, [In, Out] ref int count, [Out] UInt64[] alarm_code);

        //取得整體速度倍率
        [DllImport("HRSDK.dll")]
        public static extern int get_override_ratio(int robot);

        //設定加速度比例
        [DllImport("HRSDK.dll")]
        public static extern int set_acc_dec_ratio(int robot, int v);

        //設定整體速度倍率
        [DllImport("HRSDK.dll")]
        public static extern int set_override_ratio(int robot, int v);

        #endregion --系統變數命令--

        #region --控制器設定命令--

        //清除錯誤
        [DllImport("HRSDK.dll")]
        public static extern int clear_alarm(int robot);

        //取得伺服狀態
        [DllImport("HRSDK.dll")]
        public static extern int get_motor_state(int robot);

        //取得安全限速功能狀態
        [DllImport("HRSDK.dll")]
        public static extern int get_speed_limit_state(int robot);

        //伺服設定
        [DllImport("HRSDK.dll")]
        public static extern int set_motor_state(int robot, int onOff);

        //安全限速功能關閉
        [DllImport("HRSDK.dll")]
        public static extern int speed_limit_off(int robot);

        //安全限速功能開啟
        [DllImport("HRSDK.dll")]
        public static extern int speed_limit_on(int robot);

        #endregion --控制器設定命令--

        #region --運動命令--

        #region -點對點運動-

        /// <summary>
        /// 絕對關節角度點對點運動
        /// mode:平滑模式
        /// 0:關閉平滑模式
        /// 1:依兩線段速度平滑
        /// </summary>
        /// <param name="robot"></param>
        /// <param name="mode"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        [DllImport("HRSDK.dll")]
        public static extern int ptp_axis(int robot, int mode, double[] point);

        /// <summary>
        /// 絕對座標位置點對點運動
        /// mode:平滑模式
        /// 0:關閉平滑模式
        /// 1:依兩線段速度平滑
        /// </summary>
        /// <param name="robot"></param>
        /// <param name="mode"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        [DllImport("HRSDK.dll")]
        public static extern int ptp_pos(int robot, int mode, double[] point);

        #endregion -點對點運動-

        #region -直線運動-

        /// <summary>
        /// 絕對座標位置直線運動
        ///  mode:平滑模式
        /// 0:關閉平滑模式
        /// 1:貝茲曲線平滑百分比
        /// 2:貝茲曲線平滑半徑
        /// 3:依兩線段速度平滑
        ///  smooth_value
        /// 當mode為0,3:無效
        /// mode為1:平滑百分比(1-100%)
        /// mode為2:平滑半徑(mm)
        /// </summary>
        /// <param name="robot"></param>
        /// <param name="mode"></param>
        /// <param name="smooth_value"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        [DllImport("HRSDK.dll")]
        public static extern int lin_axis(int robot, int mode, double smooth_value, double[] point);

        /// <summary>
        /// 絕對座標位置直線運動
        ///  mode:平滑模式
        /// 0:關閉平滑模式
        /// 1:貝茲曲線平滑百分比
        /// 2:貝茲曲線平滑半徑
        /// 3:依兩線段速度平滑
        ///  smooth_value
        /// 當mode為0,3:無效
        /// mode為1:平滑百分比(1-100%)
        /// mode為2:平滑半徑(mm)
        /// </summary>
        /// <param name="robot"></param>
        /// <param name="mode"></param>
        /// <param name="smooth_value"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        [DllImport("HRSDK.dll")]
        public static extern int lin_pos(int robot, int mode, double smooth_value, double[] point);

        #endregion -直線運動-

        #region -圓弧運動-

        //絕對座標位置圓弧運動
        /// <summary>
        ///絕對座標位置圓弧運動
        /// mode:平滑模式
        /// 0:關閉平滑模式
        /// 1:依兩線段速度平滑
        /// </summary>
        /// <param name="robot"></param>
        /// <param name="mode"></param>
        /// <param name="point_aux"></param>
        /// <param name="point_end"></param>
        /// <returns></returns>
        [DllImport("HRSDK.dll")]
        public static extern int circ_pos(int robot, int mode, double[] point_aux, double[] point_end);

        #endregion -圓弧運動-

        #endregion --運動命令--

        #region --手臂資訊命令--

        //取得關節座標
        [DllImport("HRSDK.dll")]
        public static extern int get_current_joint(int robot, [In, Out] double[] value);

        //取得絕對座標
        [DllImport("HRSDK.dll")]
        public static extern int get_current_position(int robot, [In, Out] double[] value);

        #endregion --手臂資訊命令--

        #endregion --新SDK HRSDK--

        #region --舊SDK HRMB--

        //-手臂控制
        //---點對點運動
        //HRMB <點對點運動>
        //[DllImport("HRMB.dll", EntryPoint = "ptp_axis")] //絕對關節角度點對點運動 P30
        //public static extern int ptp_joint(int robot, double[] point);

        //[DllImport("HRMB.dll", EntryPoint = "ptp_pos")] //絕對座標位置點對點運動
        //public static extern int ptp_pos1(int robot, double[] point);

        //-設定命令
        //HRMB <與裝置連線>
        //[DllImport("HRMB.dll")]
        //public static extern int Connect(String a); //與裝置連線 P14

        // <關閉與裝置連結>
        //[DllImport("HRMB.dll", EntryPoint = "Close")]  //關閉與裝置連結 P15
        //public static extern int close(int robot);

        //速度設定
        /*
        [DllImport("HRMB.dll", EntryPoint = "set_ptp_speed")]
        public static extern int set_ptp_speed(int robot); //設定點對點移動速度 p16

        [DllImport("HRMB.dll", EntryPoint = "get_ptp_speed")]
        public static extern int get_ptp_speed(int robot); //取得點對點移動速度 p17

        [DllImport("HRMB.dll", EntryPoint = "get_ptp_speedRG")]
        public static extern int get_ptp_speedRG(int robot); //取得點對點移動速度(Register) p17

        [DllImport("HRMB.dll", EntryPoint = "set_lin_speed")]
        public static extern int set_lin_speed(int robot); //設定直線移動速度 p17

        [DllImport("HRMB.dll", EntryPoint = "get_lin_speed")]
        public static extern int get_lin_speed(int robot); //取得直線移動速度 p18

        [DllImport("HRMB.dll", EntryPoint = "get_lin_speed_RG")]
        public static extern int get_lin_speed_RG(int robot); //取得直線移動速度(Register) p18
        */

        /*
        set_override_ratio //設定整體速度倍率
        get_override_ratio //取得整體速度倍率
        get_override_ratioRG //取得整體速度倍率(Register)
        */

        //工具選擇
        /*
        set_tool_number //設定工具號碼
        set_tool_number //取得工具號碼
        */

        //定義工具座標
        /*
        define_tool //定義工具座標
        get_tool_data //取得工具座標
        */

        //基底選擇
        /*
        set_base_number //設定基底號碼
        get_base_number //取得基底號碼
        */

        //定義基底座標
        /*
        define_base //設定基底座標
        get_base_data //取得基底座標
        */

        //座標校正
        /*
        tool_correct_measure //工具座標校正量測
        tool_correct_calculate //工具座標校正計算
        base_correct_measure //基底座標校正量測
        base_correct_calculate //基底座標校正計算
        */

        //---控制器設定
        //------伺服設定
        //<伺服設定>
        //[DllImport("HRMB.dll", EntryPoint = "set_motor_state")]
        //public static extern int set_motor_state2(int robot, int state); //伺服設定 p25

        //------取得伺服狀態
        // <取得伺服狀態>
        //[DllImport("HRMB.dll", EntryPoint = "get_motor_state")]
        //public static extern int get_motor_state(int robot); //取得伺服狀態 p25

        //[DllImport("HRMB.dll", EntryPoint = "set_mode")] //設定操作狀態
        //public static extern int set_mode2(int robot, int robot2);

        //[DllImport("HRMB.dll", EntryPoint = "controller_rest")]
        //public static extern int controller_rest2(int robot);//錯誤清除

        //[DllImport("HRMB.dll", EntryPoint = "get_errCodeRG")]
        //public static extern int err(int robot);//取得錯誤代碼
        //<機械手臂校正>
        //[DllImport("HRMB.dll", EntryPoint = "mastering")]
        //public static extern int mastering(int robot, int joint); //機械手臂校正 p25

        // <吋動>
        ////以下為吋動
        //[DllImport("HRMB.dll", EntryPoint = "jog_joint1P")]
        //public static extern int jog_joint1P(int robot);
        //[DllImport("HRMB.dll", EntryPoint = "jog_joint1P")]
        //public static extern int jog_joint1P2(int robot); //關節軸1

        //[DllImport("HRMB.dll", EntryPoint = "jog_joint2P")]
        //public static extern int jog_joint2P2(int robot);

        //[DllImport("HRMB.dll", EntryPoint = "jog_joint3P")]
        //public static extern int jog_joint3P2(int robot);

        //[DllImport("HRMB.dll", EntryPoint = "jog_joint4P")]
        //public static extern int jog_joint4P2(int robot);

        //[DllImport("HRMB.dll", EntryPoint = "jog_joint5P")]
        //public static extern int jog_joint5P2(int robot);

        //[DllImport("HRMB.dll", EntryPoint = "jog_joint6P")]
        //public static extern int jog_joint6P2(int robot);

        //[DllImport("HRMB.dll", EntryPoint = "jog_joint1R")]
        //public static extern int jog_joint1R2(int robot);

        //[DllImport("HRMB.dll", EntryPoint = "jog_joint2R")]
        //public static extern int jog_joint2R2(int robot);

        //[DllImport("HRMB.dll", EntryPoint = "jog_joint3R")]
        //public static extern int jog_joint3R2(int robot);

        //[DllImport("HRMB.dll", EntryPoint = "jog_joint4R")]
        //public static extern int jog_joint4R2(int robot);

        //[DllImport("HRMB.dll", EntryPoint = "jog_joint5R")]
        //public static extern int jog_joint5R2(int robot);

        //[DllImport("HRMB.dll", EntryPoint = "jog_joint6R")]
        //public static extern int jog_joint6R2(int robot);

        //[DllImport("HRMB.dll", EntryPoint = "motion_delay")]
        //public static extern int motion_delay(int robot, int delay);//運動延遲

        //[DllImport("HRMB.dll", EntryPoint = "jog_stop")]
        //public static extern int jog_stop2(int robot);//停止連續移動

        //[DllImport("HRMB.dll", EntryPoint = "get_current_jointRG")]
        //public static extern int get_current_jointRG2(int robot, double[] coor);//取得目前關節座標(RG)

        //[DllImport("HRMB.dll", EntryPoint = "get_current_cartRG")]
        //public static extern int get_current_cartRG2(int robot, double[] coor);//取得目前絕對座標(RG)

        //[DllImport("HRMB.dll", EntryPoint = "ptp_rel_axis")]
        //public static extern int ptp_rel_axis2(int robot, double[] p);//相對關節角度點對點運動

        //[DllImport("HRMB.dll", EntryPoint = "get_current_pos")]
        //public static extern int get_current_pos2(int robot, int coorType, double[] coor);//取得目前位置

        //[DllImport("HRMB.dll", EntryPoint = "lin_pos")]//P32 pos lin
        //public static extern int lin_pos1(int robot, double[] p);//絕對座標位置直線運動

        //[DllImport("HRMB.dll", EntryPoint = "circ_set_aux_pos")]
        //public static extern int circ_set_aux_pos(int robot, double[] point); //機械手臂校正 p25

        //[DllImport("HRMB.dll", EntryPoint = "circ_set_end_pos")]
        //public static extern int circ_set_end_pos(int robot, double[] point); //機械手臂校正 p25

        //[DllImport("HRMB.dll", EntryPoint = "circ_pos")]
        //public static extern int circ_pos(int robot); //機械手臂校正 p25

        //<設定加速度比例>
        //[DllImport("HRMB.dll", EntryPoint = "set_acc_dec_ratio")]
        //public static extern int set_acc_dec_ratio2(int robot, int acc); //設定加速度比例 p15

        //<取得整體速度倍率>
        //[DllImport("HRMB.dll", EntryPoint = "get_override_ratioRG")]
        //public static extern int get_override_ratioRG2(int robot);//取得整體速度(RG)

        //HRMB <設定整體速度倍率>
        //[DllImport("HRMB.dll", EntryPoint = "set_override_ratio")]
        //public static extern int set_override_ratio2(int robot, int vel);//設定整體速度

        //HRMB.dll <取得加速度比例>
        //[DllImport("HRMB.dll", EntryPoint = "get_acc_dec_ratio")]
        //public static extern int get_acc_dec_ratio(int robot); //取得加速度比例 p15

        //[DllImport("HRMB.dll", EntryPoint = "get_acc_dec_ratioRG")]
        //public static extern int get_acc_dec_ratioRG2(int robot); //取得加速度比例(Register) p16

        #endregion --舊SDK HRMB--
    }
}