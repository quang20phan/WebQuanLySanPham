using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQuanLySanPham.Services;
using WebQuanLySanPham.Models;

namespace WebQuanLySanPham
{
    public partial class formLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn__Login_Click(object sender, EventArgs e)
        {
            List<User> users = UserService.LoginClient(txt_userName.Text, txt_userPassWord.Text);
            if (users.Count != 0 )
            {
                Response.Redirect("HotProduct.aspx");

            }
            else
            {
                checkLogin.Text = "Thông tin tài khoản hoặc mật khẩu không chính xác !";
            }

        }
    }
}