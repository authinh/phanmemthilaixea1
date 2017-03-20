using PhanMemQuanLy.DAL;
using PhanMemQuanLy.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLy.MenuForm.QuanLy.CauHoi
{
    public partial class AddNewQuestion : Form
    {
        private string oldIName;
        public AddNewQuestion()
        {
            InitializeComponent();
        }
        private bool isFileExist(string filename)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Resources.ftpLink + filename);
            request.Credentials = new NetworkCredential(Resources.ftpUsername, Resources.ftpPassword);
            request.Method = WebRequestMethods.Ftp.GetDateTimestamp;
            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                return true;
            }
            catch (WebException ex)
            {
                return false;
            }
        }
        private bool fileRemove(string filename)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Resources.ftpLink + filename);
            request.Credentials = new NetworkCredential(Resources.ftpUsername, Resources.ftpPassword);
            request.Method = WebRequestMethods.Ftp.DeleteFile;
            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                return true;
            }
            catch (WebException ex)
            {
                return false;
            }
        }
        private string fileUpload(){
            openFileDialog1.ShowDialog();
            if (isFileExist(openFileDialog1.SafeFileName)) return null;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Resources.ftpLink + openFileDialog1.SafeFileName);
            request.Credentials = new NetworkCredential(Resources.ftpUsername, Resources.ftpPassword);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            byte[] fileContents = File.ReadAllBytes(openFileDialog1.FileName);
            request.ContentLength = fileContents.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            response.Close();
            return openFileDialog1.SafeFileName;
        }

        private void AddNewQuestion_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (oldIName != null) fileRemove(oldIName).ToString();

            oldIName = fileUpload();
            if (oldIName == null)
            {
                MessageBox.Show("File exist");
            }
            else
            {
                pbCauHoi.Load(Resources.serverLink + oldIName);
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (oldIName == null)
            {
                MessageBox.Show("You must select image first");
                return;
            }
            int questionID = QuestionDAL.insertQuestion(oldIName);
            List<int> ansTrue = new List<int>();
            if (ans1.Checked) ansTrue.Add(1);
            if (ans2.Checked) ansTrue.Add(2);
            if (ans3.Checked) ansTrue.Add(3);
            if (ans4.Checked) ansTrue.Add(4);
            AnswerDAL.updateAnswer(questionID, ansTrue);
            MessageBox.Show("Add Question successfuly!");
            this.Dispose();

        }
    }
}
