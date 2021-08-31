using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KAutoHelper;
using xNet;
using Newtonsoft.Json;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;

namespace reg
{
    public partial class mainGui : Form
    {
        public mainGui()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            rd_warp.Checked = true;
            rd_no.Checked = true;
            loadBitmap();
        }

        #region add data
        Bitmap TIENGVIET, TAOTAIKHOAN, TIEPTUC, GTNU, GTNAM, DANGKY, SO_1, SO_2, SO_3, SO_4, SO_5, SO_6, SO_7, SO_8, SO_9, SO_0, OK, CONFIRM_EMAIL, NEXT, ACCEPT, START, INSTALL_VPN, OK_VPN;

        void loadBitmap()
        {
            TIENGVIET = (Bitmap)Bitmap.FromFile("Data//tiengviet.png");
            TAOTAIKHOAN = (Bitmap)Bitmap.FromFile("Data//taotaikhoan.png");
            TIEPTUC = (Bitmap)Bitmap.FromFile("Data//tiep.png");
            GTNU = (Bitmap)Bitmap.FromFile("Data//gt_nu.png");
            GTNAM = (Bitmap)Bitmap.FromFile("Data//gt_nam.png");
            DANGKY = (Bitmap)Bitmap.FromFile("Data//dangky.png");
            SO_1 = (Bitmap)Bitmap.FromFile("Data//so_1.png");
            SO_2 = (Bitmap)Bitmap.FromFile("Data//so_2.png");
            SO_3 = (Bitmap)Bitmap.FromFile("Data//so_3.png");
            SO_4 = (Bitmap)Bitmap.FromFile("Data//so_4.png");
            SO_5 = (Bitmap)Bitmap.FromFile("Data//so_5.png");
            SO_6 = (Bitmap)Bitmap.FromFile("Data//so_6.png");
            SO_7 = (Bitmap)Bitmap.FromFile("Data//so_7.png");
            SO_8 = (Bitmap)Bitmap.FromFile("Data//so_8.png");
            SO_9 = (Bitmap)Bitmap.FromFile("Data//so_9.png");
            SO_0 = (Bitmap)Bitmap.FromFile("Data//so_0.png");
            OK = (Bitmap)Bitmap.FromFile("Data//ok.png");
            NEXT = (Bitmap)Bitmap.FromFile("Data//next.png");
            ACCEPT = (Bitmap)Bitmap.FromFile("Data//accept.png");
            CONFIRM_EMAIL = (Bitmap)Bitmap.FromFile("Data//confirm_email.png");
            START = (Bitmap)Bitmap.FromFile("Data//start.png");
            INSTALL_VPN = (Bitmap)Bitmap.FromFile("Data//install_vpn.png");
            OK_VPN = (Bitmap)Bitmap.FromFile("Data//ok_vpn.png");


            ho = System.IO.File.ReadAllText("Data//ho.txt").Trim().Split('\n');
            ten = System.IO.File.ReadAllText("Data//ten.txt").Trim().Split('\n');
            dauSoDT = System.IO.File.ReadAllText("Data//sdt.txt").Trim().Split('\n');

        }
        #endregion

        #region khai bao bien toan cuc
        bool isStop = false;
        int index = 0;
        String[] ho, ten, dauSoDT;
        Random rnd = new Random();
        #endregion

        private void btn_getListDevice_Click(object sender, EventArgs e)
        {
            List<String> devices = KAutoHelper.ADBHelper.GetDevices();

            if (devices.Count > 0)
            {
                dtg_listDevice.Rows.Clear();
                foreach (String deviceID in devices)
                {
                    dtg_listDevice.Rows.Add(deviceID, true);
                }
            }
            else
                MessageBox.Show("Chưa có máy nào được kết nối, vui lòng kết nối và thử lại!");
        }


        void Delay(int delay)
        {
            while (delay > 0)
            {
                Thread.Sleep(TimeSpan.FromSeconds(delay));
                delay--;
                if (isStop)
                    break;
            }
        }

        private void cms_listProxy_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "f_clipboard")
            {
                cms_listProxy.Visible = false;
                dtg_listProxy.Rows.Clear();
                try
                {
                    String clipboard_data_raw = Clipboard.GetText().Trim();
                    String[] clipboard_data = clipboard_data_raw.Split('\n');
                    for (int i = 0; i < clipboard_data.Length; i++)
                    {
                        String ip, port, username, password;
                        ip = clipboard_data[i].Split(':')[0];
                        port = clipboard_data[i].Split(':')[1];

                        try
                        {
                            username = clipboard_data[i].Split(':')[2];
                            password = clipboard_data[i].Split(':')[3];
                        }
                        catch
                        {
                            username = "";
                            password = "";
                        }
                        dtg_listProxy.Rows.Add(i + 1, ip, port, username, password);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi định dạng, định dạng là `ip:port` hoặc `ip:port:username:password`.", "Lỗi!");
                }

            }
            else if (e.ClickedItem.Name == "f_file")
            {
                cms_listProxy.Visible = false;
                dtg_listProxy.Rows.Clear();
                String file_proxy_path = "";
                OpenFileDialog fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    file_proxy_path = fileDialog.FileName;
                }
                // MessageBox.Show(file_proxy_path);
                if (file_proxy_path.EndsWith(".txt"))
                {
                    String file_proxy_data_raw = System.IO.File.ReadAllText(@file_proxy_path);
                    String[] file_proxy_data = file_proxy_data_raw.Trim().Split('\n');
                    for (int i = 0; i < file_proxy_data.Length; i++)
                    {
                        String ip, port, username, password;
                        ip = file_proxy_data[i].Split(':')[0];
                        port = file_proxy_data[i].Split(':')[1];
                        try
                        {
                            username = file_proxy_data[i].Split(':')[2];
                            password = file_proxy_data[i].Split(':')[3];
                        }
                        catch
                        {
                            username = "";
                            password = "";
                        }
                        dtg_listProxy.Rows.Add(i + 1, ip, port, username, password);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể mở file.");
                }
            }
            else if (e.ClickedItem.Name == "dlt_all")
            {
                dtg_listProxy.Rows.Clear();
            }
            else if (e.ClickedItem.Name == "dlt_row")
            {
                dtg_listProxy.Rows.RemoveAt(dtg_listProxy.CurrentCell.RowIndex);
            }


            dtg_listProxy.ClearSelection();
        }



        private void btn_start_Click(object sender, EventArgs e)
        {
            if (rd_proxy.Checked == true)
            {
                proxy();
            }
            else if(rd_warp.Checked == true)
            {
                warp();
            } else if(rd_none.Checked == true)
            {
                none();
            }
        }

        private void mainGui_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Settings st = new Settings();
            st.ShowDialog();
        }

        private void btn_exportData_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text (*.txt)|*.txt";
                sfd.FilterIndex = 2;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, rtb_listAccount.Text);
                }
            }
        }

        #region function
        void installWarp(string deviceID, DataGridViewRow rows)
        {
            rows.Cells["status"].Value = "Install Warp";
            KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} install 1111.apk", deviceID));
            KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} shell pm clear com.cloudflare.onedotonedotonedotone", deviceID));

            KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} shell monkey -p com.cloudflare.onedotonedotonedotone -c android.intent.category.LAUNCHER 1", deviceID));

            click_button(deviceID, NEXT);
            click_button(deviceID, ACCEPT);
            click_button(deviceID, START);
            click_button(deviceID, INSTALL_VPN);
            click_button(deviceID, OK_VPN);
        }

        void installFbLite(string deviceID, DataGridViewRow rows)
        {
            rows.Cells["status"].Value = "Install Fb Lite";
            KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} install lite.apk", deviceID));
        }

        void cleanFbLite(string deviceID, DataGridViewRow rows)
        {
            rows.Cells["status"].Value = "Clean Fb Lite";
            KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} shell pm clear com.facebook.lite", deviceID));

            // Accept Load Danh Ba
            KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} shell pm grant com.facebook.lite android.permission.READ_CONTACTS", deviceID));
            KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} shell pm grant com.facebook.lite android.permission.CALL_PHONE", deviceID));
        }

        void setProxy(string deviceID, DataGridViewRow rows)
        {
            rows.Cells["status"].Value = "Set Proxy";
            string host, port, username, password;
            host = rows.Cells[1].Value.ToString();
            port = rows.Cells[2].Value.ToString();
            username = rows.Cells[3].Value.ToString();
            password = rows.Cells[4].Value.ToString();

            KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} shell settings put global http_proxy {1}:{2}", deviceID, host, port));
            KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} shell settings put global global_http_proxy_host {1}", deviceID, host));
            KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} shell settings put global global_http_proxy_port {1}", deviceID, port));
            KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} shell settings put global global_http_proxy_username {1}", deviceID, username));
            KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} shell settings put global global_http_proxy_password", deviceID, password));
        }

        void openFbLite(string deviceID, DataGridViewRow rows)
        {
            rows.Cells["status"].Value = "Open Fb Lite";
            KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} shell monkey -p com.facebook.lite -c android.intent.category.LAUNCHER 1", deviceID));
            click_button(deviceID, TIENGVIET);
        }

        bool click_accept_mail(String deviceID, Bitmap NUTBAM)
        {
            int solan = 0;
            while (true)
            {
                if (solan >= 10)
                    return false;
                var screm = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                var point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screm, NUTBAM);
                if (point != null)
                {
                    try
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, point.Value.X, point.Value.Y);
                        Delay(1);
                        return true;
                    }
                    catch (Exception) { }
                }
                solan++;
            }
        }

        void click_button(String deviceID, Bitmap NUTBAM)
        {
            int solan = 0;
            while (true)
            {
                if (solan >= 10)
                    break;
                var screm = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                var point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screm, NUTBAM);
                if (point != null)
                {
                    try
                    {
                        KAutoHelper.ADBHelper.Tap(deviceID, point.Value.X, point.Value.Y);
                        Delay(1);
                        return;
                    } 
                    catch (Exception) { }
                }
                solan++;
            }
        }

        void inputName(String deviceID, DataGridViewRow rows)
        {
            Random rnd = new Random();
            String ho_inp = ho[rnd.Next(0, ho.Length)];
            String ten_inp = ten[rnd.Next(0, ten.Length)];
            rows.Cells["status"].Value = ho_inp + " " + ten_inp;
            foreach (Char c in ho_inp)
            {
                KAutoHelper.ADBHelper.InputText(deviceID, c.ToString());
                // KAutoHelper.ADBHelper.Delay(0.2);
            }
            KAutoHelper.ADBHelper.Delay(0.5);
            KAutoHelper.ADBHelper.Key(deviceID, ADBKeyEvent.KEYCODE_TAB);
            foreach (Char c in ten_inp)
            {
                KAutoHelper.ADBHelper.InputText(deviceID, c.ToString());
                // KAutoHelper.ADBHelper.Delay(0.2);
            }
            KAutoHelper.ADBHelper.Delay(0.2);
            click_button(deviceID, TIEPTUC);
        }

        void inputPhoneNumber(String deviceID, DataGridViewRow rows, String phoneNumber)
        {
            rows.Cells["status"].Value = phoneNumber;
            foreach (Char c in phoneNumber)
            {
                KAutoHelper.ADBHelper.InputText(deviceID, c.ToString());
                KAutoHelper.ADBHelper.Delay(0.2);
            }
            click_button(deviceID, TIEPTUC);
        }
        
        void inputBirthDay(String deviceID, DataGridViewRow rows)
        {
            String ngay = rnd.Next(1, 30).ToString();
            if (ngay.Length == 1)
            {
                ngay = "0" + ngay;
            }
            rows.Cells["status"].Value = "Ngay: " + ngay;
            foreach (Char i in ngay)
            {
                // KAutoHelper.ADBHelper.TapByPercent(deviceID, NUMBER_KeyBoard[int.Parse(i.ToString()), 0], NUMBER_KeyBoard[int.Parse(i.ToString()), 1]);
                if (i == '0') click_button(deviceID, SO_0);
                else if (i == '1') click_button(deviceID, SO_1);
                else if (i == '2') click_button(deviceID, SO_2);
                else if (i == '3') click_button(deviceID, SO_3);
                else if (i == '4') click_button(deviceID, SO_4);
                else if (i == '5') click_button(deviceID, SO_5);
                else if (i == '6') click_button(deviceID, SO_6);
                else if (i == '7') click_button(deviceID, SO_7);
                else if (i == '8') click_button(deviceID, SO_8);
                else if (i == '9') click_button(deviceID, SO_9);
            }
            String thang = rnd.Next(1, 13).ToString();
            if (thang.Length == 1)
            {
                thang = "0" + thang;
            }
            rows.Cells["status"].Value = "Thang: " + thang;
            foreach (Char i in thang)
            {
                //KAutoHelper.ADBHelper.TapByPercent(deviceID, NUMBER_KeyBoard[int.Parse(i.ToString()), 0], NUMBER_KeyBoard[int.Parse(i.ToString()), 1]);
                //Delay(1);
                if (i == '0') click_button(deviceID, SO_0);
                else if (i == '1') click_button(deviceID, SO_1);
                else if (i == '2') click_button(deviceID, SO_2);
                else if (i == '3') click_button(deviceID, SO_3);
                else if (i == '4') click_button(deviceID, SO_4);
                else if (i == '5') click_button(deviceID, SO_5);
                else if (i == '6') click_button(deviceID, SO_6);
                else if (i == '7') click_button(deviceID, SO_7);
                else if (i == '8') click_button(deviceID, SO_8);
                else if (i == '9') click_button(deviceID, SO_9);
            }
            String nam = rnd.Next(1980, 2005).ToString();
            rows.Cells["status"].Value = "Nam: " + nam;
            foreach (Char i in nam)
            {
                //KAutoHelper.ADBHelper.TapByPercent(deviceID, NUMBER_KeyBoard[int.Parse(i.ToString()), 0], NUMBER_KeyBoard[int.Parse(i.ToString()), 1]);
                //KAutoHelper.ADBHelper.Delay(0.5);
                if (i == '0') click_button(deviceID, SO_0);
                else if (i == '1') click_button(deviceID, SO_1);
                else if (i == '2') click_button(deviceID, SO_2);
                else if (i == '3') click_button(deviceID, SO_3);
                else if (i == '4') click_button(deviceID, SO_4);
                else if (i == '5') click_button(deviceID, SO_5);
                else if (i == '6') click_button(deviceID, SO_6);
                else if (i == '7') click_button(deviceID, SO_7);
                else if (i == '8') click_button(deviceID, SO_8);
                else if (i == '9') click_button(deviceID, SO_9);
            }

            click_button(deviceID, TIEPTUC);
        }

        void chooseGender(String deviceID, DataGridViewRow rows)
        {
            int gt = rnd.Next(0, 2);
            if (gt == 0)
            {
                click_button(deviceID, GTNU);
                rows.Cells["status"].Value = "Gender: Female";
            }
            else
            {
                click_button(deviceID, GTNAM);
                rows.Cells["status"].Value = "Gender: Male";
            }
        }

        String getPassword()
        {
            if(cb_randomPassword.Checked == true)
            {
                return rnd_pass();
            } else
            {
                return tb_passwordDefault.Text;
            }
        }

        void inputPassword(String deviceID, DataGridViewRow rows, string password)
        {
            rows.Cells["status"].Value = "Password: " + password;

            foreach(char c in password)
            {
                KAutoHelper.ADBHelper.InputText(deviceID, c.ToString());
            }
            click_button(deviceID, TIEPTUC);
        }

        void verifyMail(String deviceID, DataGridViewRow rows, string mail)
        {
            HttpRequest http = new HttpRequest();
            http.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.101 Safari/537.36 Edg/91.0.864.48";
            http.Cookies = new CookieDictionary();

            

            // click luu thong tin dang nhap
            click_button(deviceID, OK);
            KAutoHelper.ADBHelper.Delay(2);
            rows.Cells["status"].Value = "Click xác nhận bằng email";
            // click xac nhan qua email
            bool cmzxcm = click_accept_mail(deviceID, CONFIRM_EMAIL);
            if (cmzxcm)
            {
                Delay(1);
                // click to input email 
                KAutoHelper.ADBHelper.TapByPercent(deviceID, 43.1, 19.4);
                rows.Cells["status"].Value = "Dki thành công > Add mail";

                // create mail
                

                //string token = http.Get("https://mail1s.com/").ToString().Split("name=\"_token\" value=\"".ToCharArray())[1].Split('"')[0];
                //string data = String.Format("_token={0}&email={1}&domain={2}", token, mail.Split('@')[0], mail.Split('@')[1]);

                //http.Post("https://mail1s.com/mailbox/create/custom", data, "application/x-www-form-urlencoded; charset=UTF-8");
                //rows.Cells["status"].Value = "Add mail: " + mail;
                foreach (Char c in mail)
                {
                    KAutoHelper.ADBHelper.InputText(deviceID, c.ToString());
                }

                click_button(deviceID, TIEPTUC);
                //Delay(5);

            

            int so_lan_get_otp = 0;
                String otp = "";
                rows.Cells["status"].Value = "Get otp...";
                KAutoHelper.ADBHelper.TapByPercent(deviceID, 49.7, 32.1);
                // input otp here
                while (true)
                {
                    // http.Get(String.Format("https://mail1s.com/mailbox/{0}", mail)).ToString();
                    String html = http.Get(String.Format("https://getnada.com/api/v1/inboxes/{0}", mail)).ToString();

                    dynamic data = JsonConvert.DeserializeObject(html);
                    
                    for(int i = 0; i < data["msgs"].Count; i++)
                    {
                        if(data["msgs"][i]["fe"] == "registration@facebookmail.com")
                        {
                            otp = data["msgs"][i]["s"].Split(' ')[0];
                            break;
                        }
                    }
                    if(otp.Length == 0)
                    {
                        so_lan_get_otp++;
                        Delay(5);
                        rows.Cells["status"].Value = "Get otp lai, lan " + so_lan_get_otp.ToString();
                    } else
                    {
                        rows.Cells["status"].Value = "OTP: " + otp;
                        break;
                    }

                    #region dit me code nhu mau lon
                    //if (html.Length > 20)
                    //{
                    //    otp = html.Split("\"subject\":\"".ToCharArray())[1].Split(' ')[0];
                    //    rows.Cells["status"].Value = "OTP: " + otp;
                    //    break;
                    //}
                    //else
                    //{
                    //    so_lan_get_otp++;
                    //    Delay(3);
                    //    rows.Cells["status"].Value = "Get otp lai, lan " + so_lan_get_otp.ToString();
                    //}
                    #endregion
                    if (so_lan_get_otp == 30)
                        break;
                }
                if (so_lan_get_otp == 30)
                {
                    rows.Cells["status"].Value = "Checkpoint";
                }
                else
                {
                    foreach (Char c in otp)
                        KAutoHelper.ADBHelper.InputText(deviceID, c.ToString());

                    KAutoHelper.ADBHelper.Delay(0.2);
                    click_button(deviceID, OK);
                    rows.Cells["status"].Value = "Nhập OTP thành công";
                    rows.Cells["status"].Value = "Xác nhận Dki";
                    Delay(3);

                    try
                    {
                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 48.8, 34.0);
                        KAutoHelper.ADBHelper.Delay(0.2);
                        foreach (Char c in mail)
                        {
                            KAutoHelper.ADBHelper.InputText(deviceID, c.ToString());
                        }
                        KAutoHelper.ADBHelper.Delay(0.5);
                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 49.1, 41.1);
                        KAutoHelper.ADBHelper.Delay(2);
                    }
                    catch
                    {

                    }

                    click_button(deviceID, TIEPTUC);
                }
            }
            else
            {
                rows.Cells["status"].Value = "Không thể add mail";
            }
        }

        String getCookie(String deviceID, DataGridViewRow rows)
        {
            rows.Cells["status"].Value = "Đang get cookie...";
            try
            {
                KAutoHelper.ADBHelper.ExecuteCMD(String.Format("adb -s {0} pull /data/data/com.facebook.lite/files/PropertiesStore_v02 {0}.txt", deviceID));
                Delay(1);
                string lines = File.ReadAllText(deviceID + ".txt");
                string token = lines.Split(new[] { "{\"access_token\":\"" }, StringSplitOptions.None)[1].Split('"')[0];
                String c_user = lines.Split(new[] { "c_user" }, StringSplitOptions.None)[1].Split(new[] { "\"value\":\"" }, StringSplitOptions.None)[1].Split('"')[0];
                String xs = lines.Split(new[] { "xs" }, StringSplitOptions.None)[1].Split(new[] { "\"value\":\"" }, StringSplitOptions.None)[1].Split('"')[0];
                String fr = lines.Split(new[] { "fr" }, StringSplitOptions.None)[1].Split(new[] { "\"value\":\"" }, StringSplitOptions.None)[1].Split('"')[0];
                String datr = lines.Split(new[] { "datr" }, StringSplitOptions.None)[1].Split(new[] { "\"value\":\"" }, StringSplitOptions.None)[1].Split('"')[0];
                String cookie = String.Format("c_user={0}; xs={1}; fr={2}; datr={3}; wd=1368x622", c_user, xs, fr, datr);
                /*c_user + ";" + xs + ";" + fr + ";" + datr;*/
                rows.Cells["status"].Value = "Get cookie thành công";
                return cookie + "|" + token;
            }
            catch
            {
                rows.Cells["status"].Value = "Get cookie không thành công";
                return "Checkpoint";
            }
        }

        void endTask(String deviceID, DataGridViewRow rows, string password)
        {
            rows.Cells["status"].Value = "Done -> Get cookie";
            String cookie = getCookie(deviceID, rows);
            if (cookie != "Checkpoint")
            {
                string uid = cookie.Split(';')[0].Split('=')[1];
                string info = String.Format("{0}|{1}|{2}", uid, password, cookie);
                rtb_listAccount.Text += info + "\n";


                //var path_logs = "logs/" + DateTime.Now.ToFileTime() + ".txt";
                //System.IO.File.WriteAllText(path_logs, rtb_listAccount.Text);
            }
            else
            {
                rows.Cells["status"].Value = cookie;
            }
        }

        #endregion


        #region random function

        String random_phone()
        {

            Random rnd = new Random();
            string res = "+84365"; //dauSoDT[rnd.Next(0, dauSoDT.Length)];
            while(res.Length != 12)
            {
                res += rnd.Next(1, 10).ToString();
            }
            return res;
        }

        String random_email()
        {
            String res = "";
            String s = "zxcvbnmasdfghjklqwertyuiop";
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
                res += s[rnd.Next(0, s.Length)];

            return res;
        }

        String rnd_pass()
        {
            String res = "";
            String s = "zxcvbnmasdfghjklqwertyuiopZXCVBNMASDFGHJKLQWERTYUIOP!@#$%^&*()";
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
                res += s[rnd.Next(0, s.Length)].ToString();

            return res;
        }
        #endregion


        void proxy()
        {
            for (int i = 0; i < dtg_listDevice.RowCount; i++)
            {
                if ((bool)dtg_listDevice.Rows[i].Cells[1].Value == true)
                {
                    string deviceID = dtg_listDevice.Rows[i].Cells[0].Value.ToString();
                    DataGridViewRow rows = dtg_listProxy.Rows[i];
                    Task t = new Task(() =>
                    {
                        autoProxy(deviceID);
                    });
                    t.Start();
                }
            }
        }

        void warp()
        {
            dtg_listProxy.Rows.Clear();
            for (int i = 0; i < dtg_listDevice.RowCount; i++)
            {
                dtg_listProxy.Rows.Add(i, "", "", "", "");
            }
            for (int i = 0; i < dtg_listDevice.RowCount; i++)
            {
                if ((bool)dtg_listDevice.Rows[i].Cells[1].Value == true)
                {
                    string deviceID = dtg_listDevice.Rows[i].Cells[0].Value.ToString();
                    DataGridViewRow rows = dtg_listProxy.Rows[i];
                    Task t = new Task(() =>
                    {
                        autoWarp(deviceID, rows);
                    });
                    t.Start();
                }
            }
        }

        void none()
        {
            dtg_listProxy.Rows.Clear();
            for (int i = 0; i < dtg_listDevice.RowCount; i++)
            {
                dtg_listProxy.Rows.Add(i, "", "0", "", "");
            }
            for (int i = 0; i < dtg_listDevice.RowCount; i++)
            {
                if ((bool)dtg_listDevice.Rows[i].Cells[1].Value == true)
                {
                    string deviceID = dtg_listDevice.Rows[i].Cells[0].Value.ToString();
                    DataGridViewRow rows = dtg_listProxy.Rows[i];
                    Task t = new Task(() =>
                    {
                        autoNone(deviceID, rows);
                    });
                    t.Start();
                }
            }
        }


        void autoProxy(string deviceID)
        {
            while (true)
            {
                if (index == dtg_listProxy.RowCount - 1)
                    index = 0;
                DataGridViewRow rows = dtg_listProxy.Rows[index++];


                string phone_tmp, password;
                setProxy(deviceID, rows);
                installFbLite(deviceID, rows);
                cleanFbLite(deviceID, rows);
                openFbLite(deviceID, rows);

                // click Reg
                click_button(deviceID, TAOTAIKHOAN);
                click_button(deviceID, TIEPTUC);

                inputName(deviceID, rows);

                phone_tmp = random_phone();
                password = getPassword();
                inputPhoneNumber(deviceID, rows, phone_tmp);

                inputBirthDay(deviceID, rows);

                chooseGender(deviceID, rows);

                inputPassword(deviceID, rows, password);

                click_button(deviceID, DANGKY);

                if (rd_yes.Checked == true)
                {
                    string mail = random_email() + "@zetmail.com";
                    rows.Cells["status"].Value = "Done -> Verify";
                    Delay(10);
                    verifyMail(deviceID, rows, mail);
                }
                Delay(5);
                endTask(deviceID, rows, password);
            }

        }

        void autoWarp(string deviceID, DataGridViewRow rows)
        {
            while (true)
            {
                string phone_tmp, password;
                installWarp(deviceID, rows);
                installFbLite(deviceID, rows);
                cleanFbLite(deviceID, rows);
                openFbLite(deviceID, rows);

                // click Reg
                click_button(deviceID, TAOTAIKHOAN);
                click_button(deviceID, TIEPTUC);

                inputName(deviceID, rows);

                phone_tmp = random_phone();
                password = getPassword();
                inputPhoneNumber(deviceID, rows, phone_tmp);

                inputBirthDay(deviceID, rows);

                chooseGender(deviceID, rows);

                inputPassword(deviceID, rows, password);

                click_button(deviceID, DANGKY);

                if(rd_yes.Checked == true)
                {
                    string mail = random_email() + "@zetmail.com";
                    rows.Cells["status"].Value = "Done -> Verify";
                    Delay(10);
                    verifyMail(deviceID, rows, mail);
                }
                Delay(5);
                endTask(deviceID, rows, password);

            }
        }

        void autoNone(string deviceID, DataGridViewRow rows)
        {
            while (true)
            {
                string phone_tmp, password;
                setProxy(deviceID, rows);
                installFbLite(deviceID, rows);
                cleanFbLite(deviceID, rows);
                openFbLite(deviceID, rows);

                // click Reg
                click_button(deviceID, TAOTAIKHOAN);
                click_button(deviceID, TIEPTUC);

                inputName(deviceID, rows);

                phone_tmp = random_phone();
                password = getPassword();
                Delay(1);
                inputPhoneNumber(deviceID, rows, phone_tmp);

                inputBirthDay(deviceID, rows);

                chooseGender(deviceID, rows);

                inputPassword(deviceID, rows, password);

                click_button(deviceID, DANGKY);

                if (rd_yes.Checked == true)
                {
                    string mail = random_email() + "@zetmail.com";
                    rows.Cells["status"].Value = "Done -> Verify";
                    Delay(10);
                    verifyMail(deviceID, rows, mail);
                }
                Delay(5);
                endTask(deviceID, rows, password);

            }

        }
    }
}
