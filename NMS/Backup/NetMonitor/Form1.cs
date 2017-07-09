
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management; 
using System.IO;
using CustomUIControls;
using System.Data.OleDb; 
//using System.Threading;

namespace Networks

{
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form 
    {
       
        public bool flage=true;
        public bool flager = true;
        public bool flaget = true;
        public bool flagec = true;
        public bool Ostate = false;
        FileStream fs ;
        StreamWriter m_streamWriter;

      
        
        StreamWriter m_streamWriter2;
        
       
        StreamWriter m_streamWriter3;
        
       
        StreamWriter m_streamWriter4;
        


        string usname = "";
       
      
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        ConnectionOptions co;
        ManagementScope ms;
        ObjectQuery oq;
        ObjectQuery oq1;
        ObjectQuery oq2;
        public int _RefreshTime = 1;
        public string RemoteIPAddress="";
        public string RemoteUserName="";
        public string RemoteActiveTime="";
        public string totalAccessFile="";
        public string RemoteOS="";
        public bool _ShowPopUp=true;
        public int Timcnt = 0;
        public string IDealTime = "";
        public int oldcount = 0, newcount = 0;
        public string RDirPath = "";
        public static string sDBPath = @".\spyDB.mdb";
        public static string ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sDBPath + ";Persist Security Info=False;";
        public int cCount = 0;
        public int dCount = 0;
        public int cHCount = 0;
        public int rCount = 0;
        public OleDbConnection conn = new OleDbConnection();
        FileSystemWatcher[] mywatcher_List = new FileSystemWatcher[100];
        public int iWatcherCount = 0;
        public int iSharedCount = 0;
        public string[] sFileWatcherPath= new string[100];
        TaskbarNotifier taskbarNotifier1 = new TaskbarNotifier();
        Timer tim = new Timer();
        public int _CurrentActiveTab;
        public string  _CreateLogFilePath="";
        public string _DeleteLogFilePath="";
        public string _RenamedLogFilePath = "";
        public string _ChangedLogFilePath = "";

        public Form1()
        {
            InitializeComponent();

          

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
            ip.Text = System.Environment.MachineName;
            cb.Checked = true;
            ListView_init();

        }

        public void call()
        {
            conn.Close();
            conn.ConnectionString = ConnectionString;
            Auto_Refresh();            // Call AutoRefresh 
            // TaskBar_Initilization();   // Initilize TaskBar Notification
            //Set The Notify Icon
            //   NotifyIcon.ShowBalloonTip(1);
            
            listView1.Items.Clear();
            lviewSession.Items.Clear();
            lview.Items.Clear();
            Read_Shared_Folder(ip.Text, uname.Text, pass.Text, cb.Checked);
            Read_Current_Session();
            _CreateLogFilePath = Directory.GetCurrentDirectory() + @"\" + "Create_Log.Txt";
            _DeleteLogFilePath = Directory.GetCurrentDirectory() + @"\" + "Delete_Log.Txt";
            _RenamedLogFilePath = Directory.GetCurrentDirectory() + @"\" + "Renamed_Log.Txt";
            _ChangedLogFilePath = Directory.GetCurrentDirectory() + @"\" + "Changed_Log.Txt";

            //  DataColumn dc = new DataColumn();

            
           
        }
        private void Form1_Resize(object sender, System.EventArgs e)
        {
           // Hide The Form when it's minimized
            if (FormWindowState.Minimized == WindowState)
                Hide();  
        }
        private void NotifyIcon_DoubleClick(object sender, System.EventArgs e)
        {
           // Show the form when Dblclicked on Notifyicon
            Show();
            WindowState = FormWindowState.Normal;
        }

         // Area For All Menu of System Tray icon ......

        // Click on Restore...
        private void MnuRestore_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        //Click on Close...
        private void MnuClose_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    //___________________________________________________________
        // Methods for initilizing List View Header in Shared Folder
        private void ListView_init()
        {

            // List View For Shared Folder........
            listView1.View = View.Details;
            listView1.Columns.Add("Shared", -1, HorizontalAlignment.Left);
            listView1.Columns.Add("Path", -1, HorizontalAlignment.Left);
            listView1.Columns.Add("Description", -1, HorizontalAlignment.Left);
            listView1.Columns.Add("Status", -1, HorizontalAlignment.Left);
            listView1.Columns[0].Width = 100;
            listView1.Columns[1].Width = 200;
            listView1.Columns[2].Width = 200;
            listView1.Columns[3].Width = 75; 

            // List View For Current Session
            lviewSession.View = View.Details;
            lviewSession.Columns.Add("IP Address", -1, HorizontalAlignment.Left);
            lviewSession.Columns.Add("User Name", -1, HorizontalAlignment.Left);
            lviewSession.Columns.Add("Access Time(Min)", -1, HorizontalAlignment.Left);
            lviewSession.Columns.Add("Ideal Time(Min)", -1, HorizontalAlignment.Left);
            lviewSession.Columns.Add("Remote OS", -1, HorizontalAlignment.Left);
            lviewSession.Columns[0].Width = 100;
            lviewSession.Columns[1].Width = 100;
            lviewSession.Columns[2].Width = 50;
            lviewSession.Columns[3].Width = 50;
            lviewSession.Columns[4].Width = 200;

            // List of Access Files !!!!
            lview.View = View.Details;
            lview.Columns.Add("User Name", -1, HorizontalAlignment.Left);
            lview.Columns.Add("Access Shared Folder",-1 , HorizontalAlignment.Left);
            lview.Columns[0].Width = 200;
            lview.Columns[1].Width = 200;
            // List of Created Files !!!!
            
            lstCreate.View = View.Details;
            lstCreate.Columns.Add("Created File Path", -1, HorizontalAlignment.Left);
            lstCreate.Columns.Add("Date", -1, HorizontalAlignment.Left);
            lstCreate.Columns.Add("Time", -1, HorizontalAlignment.Left);
            lstCreate.Columns.Add("User", -1, HorizontalAlignment.Left);
            lstCreate.Columns[0].Width = 200;
            lstCreate.Columns[1].Width = 50;
            lstCreate.Columns[2].Width = 50;
            lstCreate.Columns[3].Width = 50; 

            // List of Deleted Files
           
            lstDelete.View = View.Details;
            lstDelete.Columns.Add("Deleted File Path", -1, HorizontalAlignment.Left);
            lstDelete.Columns.Add("Date", -1, HorizontalAlignment.Left);
            lstDelete.Columns.Add("Time", -1, HorizontalAlignment.Left);
            lstDelete.Columns[0].Width = 200;
            lstDelete.Columns[1].Width = 50;
            lstDelete.Columns[2].Width = 50; 

           // List of Renamed Files

            lstRenamed.View = View.Details;
            lstRenamed.Columns.Add("Old File Path", -1, HorizontalAlignment.Left);
            lstRenamed.Columns.Add("New File Path", -1, HorizontalAlignment.Left);
            lstRenamed.Columns.Add("Date", -1, HorizontalAlignment.Left);
            lstRenamed.Columns.Add("Time", -1, HorizontalAlignment.Left);
            lstRenamed.Columns[0].Width = 150;
            lstRenamed.Columns[1].Width = 150;
            lstRenamed.Columns[2].Width = 50; 
            lstRenamed.Columns[3].Width = 50;

           // List of Changed Files

            lstChanged .View = View.Details;
            lstChanged.Columns.Add("File Path", -1, HorizontalAlignment.Left);
            lstChanged.Columns.Add("Date", -1, HorizontalAlignment.Left);
            lstChanged.Columns.Add("Time", -1, HorizontalAlignment.Left);
            lstChanged.Columns[0].Width = 400;
            lstChanged.Columns[1].Width = 200;
            lstChanged.Columns[2].Width = 50;




            dt.Columns.Add("Created File Path", Type.GetType("System.String"));
            dt.Columns.Add("Date", Type.GetType("System.String"));
            dt.Columns.Add("Time", Type.GetType("System.String"));
            dt.Columns.Add("User", Type.GetType("System.String"));


            dt1.Columns.Add("Old File Path", Type.GetType("System.String"));
            dt1.Columns.Add("New File Path", Type.GetType("System.String"));
            dt1.Columns.Add("Date", Type.GetType("System.String"));
            dt1.Columns.Add("Time", Type.GetType("System.String"));
            dt1.Columns.Add("User", Type.GetType("System.String"));


            dt2.Columns.Add("Deleted File Path", Type.GetType("System.String"));
            dt2.Columns.Add("Date", Type.GetType("System.String"));
            dt2.Columns.Add("Time", Type.GetType("System.String"));
            dt2.Columns.Add("User", Type.GetType("System.String"));

            dt3.Columns.Add("File Path", Type.GetType("System.String"));
            dt3.Columns.Add("Date", Type.GetType("System.String"));
            dt3.Columns.Add("Time", Type.GetType("System.String"));
            dt3.Columns.Add("User", Type.GetType("System.String"));
            
        }

        private void tabShared_Click(object sender, EventArgs e)
        {

        }
        private void load_Shared_Item(int cnt,string folder,string path, string Desc,string status)
        {
            listView1.Items.Add(folder);
            listView1.Items[cnt].SubItems.Add(path);
            listView1.Items[cnt].SubItems.Add(Desc);
            listView1.Items[cnt].SubItems.Add(status);
               
        }
        private void load_Access_folder(int cnt, string username, string folder)
        {
            lview.Items.Add(username);
            lview.Items[cnt].SubItems.Add(folder);
          


            
        }
        private void Read_Shared_Folder(string ip,string uname,string pass,bool cb)
        {
            int cnt = 0;
            try
            {
                ///string ssWmiMachine1 = "\\\\" + "192.168.1.10" + "\\root\\cimv2";
                // MQL for Shaer Information
                if(cb)
                ip = System.Environment.MachineName; 

                if (!cb)
                {
                    co = new ConnectionOptions();
                    co.EnablePrivileges = true;
                    co.Username = uname;
                    co.Password = pass;
                    co.Impersonation = System.Management.ImpersonationLevel.Impersonate;
                }

                string ssWmiMachine = "\\\\" + ip + "\\root\\cimv2";

                ms = new ManagementScope(ssWmiMachine, co);

                oq2 = new ObjectQuery("SELECT * FROM Win32_Share");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(ms,oq2);

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    RDirPath = queryObj["Path"].ToString();
                    if (!RDirPath.Equals("") || RDirPath.Equals("IPC$") || RDirPath.Equals("ADMIN$"))
                    {
                        File_Watcher(RDirPath);
                    }
                    load_Shared_Item(cnt, queryObj["Name"].ToString(), queryObj["Path"].ToString(), queryObj["Description"].ToString(), queryObj["Status"].ToString());
                    cnt = cnt + 1;

                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }
        }
        
        // Wll Load Current session Data
        private void Load_Current_Session(int cnt, string ipaddress,string username, string accesstime,string ideltime,string os)
        {
             
                    lviewSession.Items.Add(ipaddress);
                    lviewSession.Items[cnt].SubItems.Add(username);
                    lviewSession.Items[cnt].SubItems.Add(accesstime);
                    lviewSession.Items[cnt].SubItems.Add(ideltime);
                    lviewSession.Items[cnt].SubItems.Add(os);  

        }
        
        private  void Read_Current_Session()
        {
            int counter = 0;
            int ActiveTime;
            int itime;
            string sharename;
            try
            {
                

                oq = new System.Management.ObjectQuery("SELECT * FROM Win32_ServerConnection");
                oq1 = new System.Management.ObjectQuery("SELECT * FROM Win32_ServerSession");

                ManagementObjectSearcher searcher = new ManagementObjectSearcher(ms ,oq);
                ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(ms ,oq1); 
                
                // Read the object 
                foreach (ManagementObject ServerQobj in searcher2.Get())
                {
                    RemoteOS = ServerQobj["ClientType"].ToString();
                    IDealTime = ServerQobj["IdleTime"].ToString();
                    itime = Int32.Parse(IDealTime) / 60;
                    IDealTime = itime.ToString();
                }
                usname = "";       
                foreach (ManagementObject queryObj in searcher.Get())
                {
                          
                    RemoteIPAddress = queryObj["ComputerName"].ToString();
                    RemoteUserName = queryObj["UserName"].ToString();
                    RemoteActiveTime = queryObj["ActiveTime"].ToString();
                    ActiveTime = (Int32.Parse(RemoteActiveTime)) / 60;
                    RemoteActiveTime = ActiveTime.ToString();
                    sharename = queryObj["ShareName"].ToString();
                    if (!sharename.Equals("IPC$"))
                    {
                        if (usname != "")
                        {
                            usname = usname + " , " + RemoteUserName;
                        }
                        else
                        {
                            usname = RemoteUserName;
                        }
                        Load_Current_Session(counter, RemoteIPAddress, RemoteUserName, RemoteActiveTime,IDealTime,RemoteOS);
                        load_Access_folder(counter, RemoteUserName, sharename);
                        counter += 1;
                    }
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
                this.Close();
            }
        }

        private void Monitor_Accessed_Files()
        {
          
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbarRefresh_Click(object sender, EventArgs e)
        {
            Refresh_All();
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lviewSession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ToolBar Refresh Button Click....


        //private void File_Watcher(string sFolderPath)
        //{
        //        FileSystemWatcher mywatcher = new FileSystemWatcher(sFolderPath);           
        //        mywatcher.Filter = "";
        //        mywatcher.NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName |  NotifyFilters.LastAccess ;
        //        mywatcher.EnableRaisingEvents = true;
        //        mywatcher.IncludeSubdirectories = true;
        //        mywatcher.Created += new FileSystemEventHandler(mywatcher_created);
        //        mywatcher.Deleted += new FileSystemEventHandler(mywatcher_deleted);
        //        mywatcher.Changed += new FileSystemEventHandler(mywatcher_changed);
        //        mywatcher.Renamed += new RenamedEventHandler(mywatcher_renamed);
        //        mywatcher_List[iWatcherCount] = mywatcher;
        //        iWatcherCount++;
           
            
        //}

        private void File_Watcher(string sFolderPath)
        {
            if (Directory.Exists(sFolderPath))
            {
                FileSystemWatcher mywatcher = new FileSystemWatcher(sFolderPath);
                mywatcher.Filter = "";
                mywatcher.NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess;
                mywatcher.EnableRaisingEvents = true;
                mywatcher.IncludeSubdirectories = true;
                mywatcher.Created += new FileSystemEventHandler(mywatcher_created);
                mywatcher.Deleted += new FileSystemEventHandler(mywatcher_deleted);
                mywatcher.Changed += new FileSystemEventHandler(mywatcher_changed);
                mywatcher.Renamed += new RenamedEventHandler(mywatcher_renamed);
      
                if (iWatcherCount >= 100)
                {
                    Array.Resize(ref mywatcher_List, iWatcherCount + 1);
                }
                mywatcher_List[iWatcherCount] = mywatcher;
                iWatcherCount++;
            }


        }

        protected void mywatcher_created(object sender,FileSystemEventArgs  e)
        {
           // cCount = 0;
           CheckForIllegalCrossThreadCalls = false;
           DateTime current = DateTime.Now;
           FileInfo fi = new FileInfo(e.FullPath.ToString());
           if (fi.Extension != ".cmd" && fi.Extension != ".inf")
           {
                    string ss = e.FullPath.ToString();
                       
              
                
                  // object[] va3 ={ ss, current.ToShortDateString(), current.ToShortTimeString(), usname };
                   try
                   {
                       DataRow dr;
                       dr = dt.NewRow();
                       dr[0] = ss;
                       dr[1] = current.ToShortDateString();
                       dr[2] = current.ToShortTimeString();
                       dr[3] = usname;
                       dt.Rows.Add(dr);
                   
                       dataGridView1.DataSource = dt;
                       dataGridView1.Update();
                    }
                   catch { }
                  

                           try
                           {
                               if (flage == true)
                               {
                                   fs = new FileStream(@"c:\fcreated.txt", FileMode.Append, FileAccess.Write);
                                   m_streamWriter = new StreamWriter(fs);

                                   m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
                                   flage = false;
                               }
                               m_streamWriter.WriteLine(current.ToShortDateString() + "    " + current.ToShortTimeString() + "  " + "Created" + "    "+ ss + "     " +   usname + "\n");
                               m_streamWriter.Flush();
                               
                           }
                           catch
                           {
                           //    m_streamWriter.Close();
                         //      fs.Close();
                               flage = true;
                           }
                           cCount += 1;                  
                  
           }
    
               
               
           }

        
        protected void mywatcher_renamed(object sender,RenamedEventArgs r)
        {
           // cCount = 0;
            CheckForIllegalCrossThreadCalls = false;
            DateTime current = DateTime.Now;
            FileInfo fi = new FileInfo(r.FullPath.ToString());
            if (fi.Extension != ".cmd" && fi.Extension != ".inf")
            {
              
                try
                {
                    DataRow dr3;
                    dr3 = dt1.NewRow();
                    dr3[0] = r.OldFullPath.ToString();
                    dr3[1] = r.FullPath.ToString();
                    dr3[2] = Convert.ToString( current.ToShortDateString());
                    dr3[3] = Convert.ToString(current.ToShortTimeString());
                    dr3[4] = usname;
                    dt1.Rows.Add(dr3);

                    dataGridView3.DataSource = dt1;
                    dataGridView3.Update();
                }
                catch { }
               
               
               
                

                try
                {
                    if (flager == true)
                    {
                       // fs4 = new FileStream(@"c:\frenamed.txt", FileMode.Append, FileAccess.Write);
                        m_streamWriter4 = new StreamWriter(fs);

                        m_streamWriter4.BaseStream.Seek(0, SeekOrigin.End);
                        flager = false;
                    }

                    m_streamWriter4.WriteLine(current.ToShortDateString() + "    " + current.ToShortTimeString() + "  " + "Renamed" + "    " + r.OldFullPath.ToString() + "   " + r.FullPath.ToString() + "   " + usname + "\n");
                    m_streamWriter4.Flush();

                }
                catch
                {
                  //  m_streamWriter4.Close();
                   // fs4.Close();
                    flager = true;
                }


                rCount += 1;
            }
      
        }
        protected void mywatcher_deleted(object sender, FileSystemEventArgs e)
        {
           dCount = 0;
            CheckForIllegalCrossThreadCalls = false;
            DateTime current = DateTime.Now;
            FileInfo fi = new FileInfo(e.FullPath.ToString());
           if (fi.Extension != ".cmd" && fi.Extension != ".inf")
           {
            
              
               try
               {
                   DataRow dr1;
                   dr1 = dt2.NewRow();
                   dr1[0] = e.FullPath.ToString();
                   dr1[1] = Convert.ToString(current.ToShortDateString());
                   dr1[2] = Convert.ToString(current.ToShortTimeString());
                   dr1[3] = usname;
                   dt2.Rows.Add(dr1);
                   dataGridView2.DataSource = dt2;
                   dataGridView2.Update();
               }
               catch { }
                 
               try
               {
                   if (flaget == true)
                   {
                      // fs2 = new FileStream(@"c:\fdeleted.txt", FileMode.Append, FileAccess.Write);
                       m_streamWriter2 = new StreamWriter(fs);

                       m_streamWriter2.BaseStream.Seek(0, SeekOrigin.End);
                       flaget = false;
                   }

                   m_streamWriter2.WriteLine(current.ToShortDateString() + "    " + current.ToShortTimeString() + "  " + "Deleted" + "    "+e.FullPath.ToString() + "         " +  usname + "\n");
                   m_streamWriter2.Flush();

               }
               catch
               {
                //  m_streamWriter2.Close();
                 // fs2.Close();
                   flaget = true;
               }

            }
            
        }
        public void checkdata(object o,DataGridViewDataErrorEventArgs de)
        {

        //    MessageBox.Show("Data gridview Data Error"+de.RowIndex +"  "+de.Context );

         //   de.Cancel = true;


        }
        protected void mywatcher_changed(object sender, FileSystemEventArgs e)
        {/*

            dataGridView4.DataError += new DataGridViewDataErrorEventHandler(checkdata);
            cHCount = 0;
            CheckForIllegalCrossThreadCalls = false;
            DateTime current = DateTime.Now;
            FileInfo fi = new FileInfo(e.FullPath.ToString());
            if (fi.Extension != ".cmd" && fi.Extension != ".inf")
            {
                

                try
                {
                    string c = e.FullPath.ToString().ToLower();
                    if ( c!="c:\\fcreated.txt" && fi.Extension != ".dll" && fi.Extension.ToLower() != ".log" && fi.Extension.ToLower() !=".pf" )
                    {
                        try
                        {
                            DataRow dr5;
                            dr5 = dt3.NewRow();
                            dr5[0] = e.FullPath.ToString();
                            dr5[1] = Convert.ToString(current.ToShortDateString());
                            dr5[2] = Convert.ToString(current.ToShortTimeString());
                            dr5[3] = usname;
                            dt3.Rows.Add(dr5);
                            dataGridView4.DataSource = dt3;
                            dataGridView4.Update();
                        }
                        catch { }

                        m_streamWriter3 = new StreamWriter(fs);

                        m_streamWriter3.BaseStream.Seek(0, SeekOrigin.End);
                        m_streamWriter3.WriteLine(current.ToShortDateString() + "    " + current.ToShortTimeString()+"  "+ "Changed" + "    "  +e.FullPath.ToString()  + "  "  + usname + "\n");
                        m_streamWriter3.Flush();      
                    }
                }
                catch { }

                    
            }*/
            
        }
        private void TaskBar_Initilization()
         {
           //taskbarNotifier1.SetBackgroundBitmap(new Bitmap(GetType(), "skin"), Color.FromArgb(255, 0, 255));
            taskbarNotifier1.SetBackgroundBitmap("Skin.bmp", Color.FromArgb(255, 0, 255));
            //taskbarNotifier1.SetCloseBitmap(new Bitmap(GetType(), "close"), Color.FromArgb(255, 0, 255), new Point(127, 8));
            taskbarNotifier1.SetCloseBitmap("close.bmp", Color.FromArgb(255, 0, 255), new Point(127, 8));
            taskbarNotifier1.TitleRectangle = new Rectangle(40, 9, 70, 25);
            taskbarNotifier1.ContentRectangle = new Rectangle(8, 41, 133, 68);
            taskbarNotifier1.TitleClick += new EventHandler(TitleClick);
            taskbarNotifier1.ContentClick += new EventHandler(ContentClick);
            taskbarNotifier1.CloseClick += new EventHandler(CloseClick);
        }
        void CloseClick(object obj, EventArgs ea)
        {
           // MessageBox.Show("Closed was Clicked");
        }

        void TitleClick(object obj, EventArgs ea)
        {
            //MessageBox.Show("Title was Clicked");
        }

        void ContentClick(object obj, EventArgs ea)
        {
           // MessageBox.Show("Content was Clicked");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        void Show_popUP()
        {
            string t1 = "500";
            string t2 = "3000";
            string t3 = "500";
            taskbarNotifier1.CloseClickable = true;
            taskbarNotifier1.TitleClickable = false;
            taskbarNotifier1.ContentClickable = true;
            taskbarNotifier1.EnableSelectionRectangle = true;
            taskbarNotifier1.KeepVisibleOnMousOver = true;	// Added Rev 002
            taskbarNotifier1.ReShowOnMouseOver = true;			// Added Rev 002
            taskbarNotifier1.Show("Monitoring", RemoteUserName + "\n Is Now Accessing Your System ", Int32.Parse(t1), Int32.Parse(t2), Int32.Parse(t3));
        }

        private void Auto_Refresh()
        {
            tim.Start();
            tim.Tick+=new EventHandler(tim_Tick); 
        }
      void tim_Tick(object obj, EventArgs ea)
        {
            Timcnt+=1;
            newcount = lviewSession.Items.Count;
           if (oldcount != newcount)
            {
              
                oldcount = newcount;
            }
            if (Timcnt > 100*_RefreshTime)
            {
                
                Refresh_All();
                oldcount = newcount; 
                Timcnt = 0;
            }
        }
        private void Refresh_All()
        {
            int len;

            
            len = RemoteUserName.Length;
            //if(len>0 )
            //{
            //   if(_ShowPopUp) 
            //        // Show_popUP();
         
            //}
            for (int i = 0; i < iWatcherCount; i++)
                 mywatcher_List[i].Dispose();

            listView1.Items.Clear();
            lviewSession.Items.Clear();
            lview.Items.Clear();
            if (Ostate)
            {
                try
                {

                    Read_Shared_Folder(ip.Text, uname.Text, pass.Text, cb.Checked);
                    Read_Current_Session();
                }
                catch { }


            }
        }




        private void settingsToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (this.settingsToolStripMenuItem1.Checked == true)
            {
                _ShowPopUp = false;
                this.settingsToolStripMenuItem1.Checked = false;
            }
            else
            {
                _ShowPopUp = true;
                this.settingsToolStripMenuItem1.Checked = true;
            }

            //MessageBox.Show(_ShowPopUp.ToString());
            
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            toolStripMenuItem6.Checked = true;
            toolStripMenuItem7.Checked = false ;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            _RefreshTime = 5;

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = true;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            _RefreshTime = 10;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = true;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            _RefreshTime = 25;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            toolStripMenuItem6.Checked = false ;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = true;
            toolStripMenuItem10.Checked = false;
            _RefreshTime = 30;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = true;
            _RefreshTime = 50;
        }

        

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("VerySimple To Use", "Monitoring", MessageBoxButtons.OK, MessageBoxIcon.Information); 

        }


        /// <summary>
        /// Click on Clear Log History
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Right_ClearLogHistry_Click(object sender, EventArgs e)
        {
            switch (_CurrentActiveTab)
            {
                case 1:
                    ClearLogHistory(1);
                    break;
                case 2:
                    ClearLogHistory(2);
                    break;
                case 3:
                    ClearLogHistory(3);
                    break;
                case 4:
                    ClearLogHistory(4);
                    break;
            }
            
        }
        /// <summary>
        /// Clearing The History of Current Grid
        /// </summary>
        /// <param name="_ActiveTab">Current Selected Grid</param>
        protected void ClearLogHistory(int _ActiveTab)
        {
            int Count;
            switch (_ActiveTab)
            {
                case 1: //Clear The Create Grid List
                     Count = lstCreate.Items.Count;
                     while (Count != 0)
                     {
                         Count--;
                         lstCreate.Items[Count].Remove();
                         
                     }
                     cCount = 0;
                    break;
                case 2:  //Clear The Delete Grid List
                     Count = lstDelete.Items.Count;                   for (int i = 0; i < Count; i++)
                         while (Count != 0)
                         {
                             Count--;
                             lstDelete.Items[Count].Remove();

                         }
                     dCount = 0;
                    break;
                case 3:   //Clear The Renamed Grid List
                     Count = lstRenamed.Items.Count;
                     while (Count != 0)
                     {
                         Count--;
                         lstRenamed.Items[Count].Remove();

                     }
                     rCount = 0;
                    break;
                case 4: //Clear The Changed Grid List
                     Count = lstChanged.Items.Count;
                     while (Count != 0)
                     {
                         Count--;
                         lstChanged.Items[Count].Remove();
                      
                      }
                      cHCount = 0;
                    break;
            }
        }

        /// <summary>
        /// Check The Right Click on Create File List Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCreate_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
                _CurrentActiveTab = 1;
        }
        /// <summary>
        /// Check Right Click on File Delete Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstDelete_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                _CurrentActiveTab = 2;
        }
/// <summary>
/// Check Right Click on Rename Grid
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void lstRenamed_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                _CurrentActiveTab = 3;
        }
        /// <summary>
        /// Check Right Click on File Changed Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstChanged_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                _CurrentActiveTab = 4;
        }

      /// <summary>
      /// Right Click for check the current Active/ Accessing USer
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void RightCurrentUser_Click(object sender, EventArgs e)
        {
            int Count;
            string _ActiveUser="Current Active IP :\n";
             Count = lviewSession.Items.Count;
                     while (Count != 0)
                     {
                         Count--;

                        _ActiveUser+= lviewSession.Items[Count].Text.ToString() + "\n";   
                     }
                     MessageBox.Show(_ActiveUser, "Monitoring your Pc", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                             
        }
        /// <summary>
        /// Export Result To Text File !!!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightExportToFile_Click(object sender, EventArgs e)
        {
            switch (_CurrentActiveTab)
            {
                case 1:
                    ExportToTextFile(1);
                    break;
                case 2:
                    ExportToTextFile(2);
                    break;
                case 3:
                    ExportToTextFile(3);
                    break;
                case 4:
                    ExportToTextFile(4);
                    break;

            }
            
        }
        /// <summary>
        /// Export The ListView Result To TextFile
        /// </summary>
        /// <param name="_ActiveTab">Tab Index</param>
        public void ExportToTextFile(int _ActiveTab)
        {

            int Count;
            string _Result="";
            bool _ClearFlag = false;
            switch(_ActiveTab)
            {
                case 1:
                 Count=lstCreate.Items.Count;
                 if (Count != 0)
                 {
                     TextWriter Tw = new StreamWriter(_CreateLogFilePath);
                     Tw.WriteLine("Created FilePath" + "\t" + "Date" + "\t" + "Time");
                     Tw.WriteLine("-----------------------------------------------------------------");
                     for (int j = 0; j < Count; j++)
                     {
                         ListViewItem lvi = lstCreate.Items[j];

                         for (int i = 0; i < lvi.SubItems.Count; i++)
                         {

                             _Result += lvi.SubItems[i].Text + "\t";
                         }

                         Tw.WriteLine(_Result);
                         _Result = "";
                     }
                     Tw.Close();
                     _Result = "";
                     _ClearFlag = true;

                 }
                 else
                 {
                     MessageBox.Show("Nothing to store in log file !", "NWM: Logging", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     _ClearFlag = false;
                 }
                 break;

             case 2:
                 Count = lstDelete.Items.Count;
                 if (Count != 0)
                 {
                     TextWriter Tw1 = new StreamWriter(_DeleteLogFilePath);
                     Tw1.WriteLine("Deleted FilePath" + "\t" + "Date" + "\t" + "Time");
                     Tw1.WriteLine("-----------------------------------------------------------------");
                     for (int j = 0; j < Count; j++)
                     {
                         ListViewItem lvi = lstDelete.Items[j];
                         for (int i = 0; i < lvi.SubItems.Count; i++)
                         {
                             _Result += lvi.SubItems[i].Text + "\t";
                         }
                         Tw1.WriteLine(_Result);
                         _Result = "";
                     }
                     Tw1.Close();
                     _Result = "";
                     _ClearFlag = true;
                 }
                 else
                 {
                     MessageBox.Show("Nothing to store in log file !", "NWM: Logging", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     _ClearFlag = false;
                 }
                 break;
             case 3:
                 Count = lstRenamed.Items.Count;
                 if (Count != 0)
                 {
                     TextWriter Tw2 = new StreamWriter(_RenamedLogFilePath);
                     Tw2.WriteLine("Old FilePath" + "\t" + "New File Path" + "\t" + "Date" + "\t" + "Time");
                     Tw2.WriteLine("-----------------------------------------------------------------");
                     for (int j = 0; j < Count; j++)
                     {
                         ListViewItem lvi = lstRenamed.Items[j];
                         for (int i = 0; i < lvi.SubItems.Count; i++)
                         {
                             _Result += lvi.SubItems[i].Text + "\t";
                         }
                         Tw2.WriteLine(_Result);
                         _Result = "";
                     }
                     Tw2.Close();
                     _Result = "";
                     _ClearFlag = true;
                 }
                 else
                 {
                     MessageBox.Show("Nothing to store in log file !", "NWM: Logging", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     _ClearFlag = false;
                 }
                 break;
             case 4:
                 Count = lstChanged.Items.Count;
                 if (Count != 0)
                 {
                     TextWriter Tw3 = new StreamWriter(_ChangedLogFilePath);
                     Tw3.WriteLine("Changed FilePath" + "\t" + "Date" + "\t" + "Time");
                     Tw3.WriteLine("-----------------------------------------------------------------");
                     for (int j = 0; j < Count; j++)
                     {
                         ListViewItem lvi = lstChanged.Items[j];
                         for (int i = 0; i < lvi.SubItems.Count; i++)
                         {
                             _Result += lvi.SubItems[i].Text + "\t";
                         }
                         Tw3.WriteLine(_Result);
                         _Result = "";
                     }
                     Tw3.Close();
                     _Result = "";
                     _ClearFlag = true;
                 }
                 else
                 {
                     MessageBox.Show("Nothing to store in log file !", "NWM: Logging", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     _ClearFlag = false;
                 }
                 break;
            }

            if (_ClearFlag == true)
            {
                DialogResult Result = MessageBox.Show("Log has been written successfuly !\n Do you want to clear this Grid ?", "NWM : Loging", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Result == DialogResult.Yes)
                {
                    //Clear the Grid 
                    ClearLogHistory(_CurrentActiveTab);
                }
            }
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearLogHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearLog();



           
        }
        public void ClearLog()
        {

            dt.Clear();
            dt1.Clear();
            dt2.Clear();
            dt3.Clear();     
        }

        private void BtnStartMonitor_Click(object sender, EventArgs e)
        {
            Ostate = true;
            BtnStopMonitor.Visible = true;
            BtnStopMonitor.Enabled = true;
           // button1.Text = "Logout";
            BtnStartMonitor.Enabled = false;
            call();
        }

        private void BtnStopMonitor_Click(object sender, EventArgs e)
        {
            Ostate = false;
            BtnStartMonitor.Enabled = true;
            //ListView_init();
            listView1.Items.Clear();
            lviewSession.Items.Clear();
            lview.Items.Clear();
        }

       
      


        }




    
}
