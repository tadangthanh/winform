using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Util
{
    internal class Validation
    {
        private Dictionary<TextBox, bool> errorProviderForTextBox = new Dictionary<TextBox, bool>();

        public bool validate(TextBox tb, TypeRegex typeRegex, ErrorProvider err)
        {
            if (typeRegex == TypeRegex.NumberPhone)
            {
                if (!Regex.IsMatch(tb.Text, @"^\d{10}$") && tb.Text.Length > 0)
                {
                    err.SetError(tb, "Số không hợp lệ!");
                    errorProviderForTextBox[tb]=true;
                    return true;
                }
                else
                {
                    errorProviderForTextBox[tb] = false;

                    err.Clear();
                }
            }
            if (typeRegex == TypeRegex.Email)
            {
                if (!Regex.IsMatch(tb.Text, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") && tb.Text.Length > 0)
                {
                    err.SetError(tb, "Email không hợp lệ!");
                    errorProviderForTextBox[tb] = true;
                    return true;
                }
                else
                {
                    errorProviderForTextBox[tb] = false;


                    err.Clear();
                }
            }
            if (typeRegex == TypeRegex.CCCD)
            {
                if (!Regex.IsMatch(tb.Text, @"^\d{12}$") )
                {
                    err.SetError(tb, "Căn cước không hợp lệ!");
                    errorProviderForTextBox[tb] = true;
                    return true;
                }
                else
                {
                    errorProviderForTextBox[tb] = false;
                    err.Clear();
                }
            }
            if (typeRegex == TypeRegex.Name)
            {
                if (!Regex.IsMatch(tb.Text, @"[\p{L}]") && tb.Text.Length >0)
                {
                    err.SetError(tb, "Kí tự không hợp lệ!");
                    errorProviderForTextBox[tb] = true;
                    return true;
                }
                else
                {
                    errorProviderForTextBox[tb] = false;
                    err.Clear();
                }
            }
            return false;
        }
        public bool checkAll()
        {
            if(errorProviderForTextBox.ContainsValue(true)) return false;
            return true;
        }

    }
}
