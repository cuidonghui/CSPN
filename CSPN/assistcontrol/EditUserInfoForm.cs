﻿using CSPN.BLL;
using CSPN.common;
using CSPN.helper;
using CSPN.IBLL;
using CSPN.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSPN.assistcontrol
{
    public partial class EditUserInfoForm : Form
    {
        private IUsersService userService = new UsersService();
        private UsersInfo usersInfo = null;
        private UserLogHelper userLogHelper = new UserLogHelper();

        private bool _isInsert = false;
        private string _work_ID = null;

        //编辑时将选中信息加载到窗体上
        public EditUserInfoForm(bool isInsert, string work_ID)
        {
            InitializeComponent();
            _isInsert = isInsert;
            _work_ID = work_ID;
        }

        private void EditUserInfoForm_Load(object sender, EventArgs e)
        {
            usersInfo = new UsersInfo();
            if (_isInsert)
            {
                Text = "添加数据";
                Icon = new Icon("resource/images/add.ico");
                btnSure.Text = "确定添加";
                cmbGender.SelectedIndex = 0;
            }
            else
            {
                Text = "更新数据";
                Icon = new Icon("resource/images/update.ico");
                btnSure.Text = "确定修改";
                txtWorkID.Enabled = false;

                usersInfo = userService.GetUsersByWork_ID(_work_ID);
                txtWorkID.Text = usersInfo.Work_ID.Trim();
                txtRealName.Text = usersInfo.RealName.Trim();
                if (usersInfo.Gender.Trim() == "男")
                {
                    cmbGender.SelectedIndex = 0;
                }
                else
                {
                    cmbGender.SelectedIndex = 1;
                }
                txtTelephone.Text = usersInfo.Telephone.Trim();
                txtUserName.Text = usersInfo.UserName.Trim();
            }
        }

        //确定添加/更新
        private void btnSure_Click(object sender, EventArgs e)
        {
            usersInfo = new UsersInfo()
            {
                Work_ID = txtWorkID.Text.Trim(),//工号
                RealName = txtRealName.Text.Trim(),//姓名
                Gender = cmbGender.SelectedItem.ToString().Trim(),//性别
                Telephone = txtTelephone.Text.Trim(),//联系方式
                UserName = txtUserName.Text.Trim(),//用户名
                PassWord = SysFunction.GetSecurit("123456CSPN" + txtUserName.Text.Trim())
            };

            if (txtWorkID.Text.Trim() == "")
            {
                UMessageBox.Show("请输入人员工号！", "人井监控管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtRealName.Text.Trim() == "")
            {
                UMessageBox.Show("请输入人员姓名！", "人井监控管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTelephone.Text.Trim() == "")
            {
                UMessageBox.Show("请输入人员手机号！", "人井监控管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //添加
            if (_isInsert)
            {
                if (userService.GetUsersByWork_ID(txtWorkID.Text.Trim()) != null)
                {
                    UMessageBox.Show("该人员已存在，请勿重复添加！", "人井监控管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (userService.InsertUserInfo(usersInfo) > 0)
                    {
                        UMessageBox.Show("数据添加成功！", "人井监控管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userLogHelper.InsertUserLog(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), "添加用户信息。", CommonClass.UserName, null, null, null);
                        Close();
                    }
                    else
                    {
                        UMessageBox.Show("数据添加失败！", "人井监控管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //更新
            else
            {
                if (userService.UpdateUserInfo(usersInfo) > 0)
                {
                    UMessageBox.Show("数据修改成功！", "人井监控管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userLogHelper.InsertUserLog(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), "更新用户信息。", CommonClass.UserName, null, null, null);
                    Close();
                }
                else
                {
                    UMessageBox.Show("数据修改失败！", "人井监控管理系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}