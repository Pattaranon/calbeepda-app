using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Calbee.Infra.Helper.Message
{
    public class MsgBox
    {
        /// <summary>
        /// ผลการทำงาน
        /// </summary>
        /// <param name="field">ข้อความที่ต้องการแสดง</</param>
        public static void ShowResult(string msg)
        {
            MessageBox.Show(msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// ผลการตรวจสอบ (Invalid)
        /// </summary>
        /// <param name="msg">ข้อความที่ต้องการแสดง</param>
        public static void ShowExclamation(string msg)
        {
            MessageBox.Show(msg, "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// การยืนยัน (Invalid)
        /// </summary>
        /// <param name="msg">ข้อความที่ต้องการแสดง</param>
        public static void ShowConfrim(string msg)
        {
            MessageBox.Show(msg, "Confrim", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// แสดงข้อผิดพลาด
        /// </summary>
        /// <param name="msg">ข้อความที่ต้องการแสดง</param>
        /// <param name="ex">Exception object</param>
        public static void ShowErrorTryCatch(string msg, Exception ex)
        {
            MessageBox.Show(msg + "\nข้อผิดพลาดจากระบบ : \n" + ex.ToString().Replace("System.Exception:", ""), "ข้อผิดพลาด",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// ผลการทำงาน
        /// </summary>
        /// <param name="field">ข้อความที่ต้องการแสดง</</param>
        public static void DialogInfomation(string msg)
        {
            MessageBox.Show(msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// ผลการตรวจสอบ (Invalid)
        /// </summary>
        /// <param name="msg">ข้อความที่ต้องการแสดง</param>
        public static void DialogWarning(string msg)
        {
            MessageBox.Show(msg, "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }
        public static void DialogError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// การยืนยัน (Invalid)
        /// </summary>
        /// <param name="msg">ข้อความที่ต้องการแสดง</param>
        public static void DialogConfirm(string msg)
        {
            MessageBox.Show(msg, "Confrim", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
        /// <summary>
        /// คำถาม (Valid)
        /// </summary>
        /// <param name="msg"></param>
        public static DialogResult DialogQuestion(string msg)
        {
            return MessageBox.Show(msg, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// แสดงข้อผิดพลาด
        /// </summary>
        /// <param name="msg">ข้อความที่ต้องการแสดง</param>
        /// <param name="ex">Exception object</param>
        public static void DialogErrorTryCatch(string msg, Exception ex)
        {
            MessageBox.Show(msg + "\nข้อผิดพลาดจากระบบ : \n" + ex.ToString().Replace("System.Exception:", ""), "ข้อผิดพลาด",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }
    }
}