using GitDependencies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace UnrealSetupCacheBuilder
{
    public partial class Form1 : Form
    {
        const string GitDepsRelativePath = @"Engine\Build\Commit.gitdeps.xml";

        string GitDepsPath;
        string CachePath;
        string TargetPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Engine_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == FolderDialog.ShowDialog())
            {
                TB_Engine.Text = FolderDialog.SelectedPath;
                if (TB_Cache.Text.Length == 0)
                {
                    string TmpPath = Path.Combine(TB_Engine.Text, @".git\ue4-gitdeps");
                    if (Directory.Exists(TmpPath))
                    {
                        TB_Cache.Text = TmpPath;
                    }
                }
            }
        }

        private void BTN_Cache_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == FolderDialog.ShowDialog())
            {
                TB_Cache.Text = FolderDialog.SelectedPath;
            }
        }

        private void BTN_Target_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == FolderDialog.ShowDialog())
            {
                TB_Target.Text = FolderDialog.SelectedPath;
            }
        }

        private void BTN_Build_Click(object sender, EventArgs e)
        {
            GitDepsPath = Path.Combine(TB_Engine.Text, GitDepsRelativePath);
            CachePath = TB_Cache.Text;
            TargetPath = TB_Target.Text;

            if (!Directory.Exists(TB_Engine.Text)
                || !File.Exists(GitDepsPath))
            {
                MessageBox.Show(@"Invalid Engine Path!");
                return;
            }

            if (!Directory.Exists(CachePath))
            {
                MessageBox.Show(@"Invalid Cache Path!");
                return;
            }

            if (!Directory.Exists(TargetPath))
            {
                Directory.CreateDirectory(TargetPath);
                if (!Directory.Exists(TargetPath))
                {
                    MessageBox.Show(@"Invalid Target Path!");
                    return;
                }
            }

            BGWorker.RunWorkerAsync();

            LB_Log.Text = @"Working...";
        }

        private void BGWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DependencyManifest NewTargetManifest;
            if (!ReadXmlObject(GitDepsPath, out NewTargetManifest))
            {
                return;
            }

            Dictionary<string, string> TargetPacks = new Dictionary<string, string>();
            foreach (DependencyPack NewPack in NewTargetManifest.Packs)
            {
                TargetPacks.Add(NewPack.Hash, NewPack.RemotePath);
            }

            string[] Files = Directory.GetFiles(CachePath, @"*", SearchOption.AllDirectories);
            int Count = 0;
            foreach (string FileEntry in Files)
            {
                string Filename = Path.GetFileName(FileEntry);
                if (TargetPacks.ContainsKey(Filename))
                {
                    string TargetPackPath = Path.Combine(TargetPath, TargetPacks[Filename]);
                    Directory.CreateDirectory(TargetPackPath);
                    if (!Directory.Exists(TargetPackPath))
                    {
                        Console.WriteLine("Failed to create path {0}", TargetPackPath);
                        continue;
                    }
                    File.Copy(FileEntry, Path.Combine(TargetPackPath, Filename));
                }
                BGWorker.ReportProgress(  ++Count * 100 / Files.Length  );
            }
        }

        private void BGWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            PGBar.Value = e.ProgressPercentage;
        }

        private void BGWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            LB_Log.Text = @"Done";
        }

        public delegate void SetProgressDelegate(int Progress);
        private void SetProgress(int Progress)
        {
            if (PGBar.InvokeRequired)
            {
                PGBar.BeginInvoke(new SetProgressDelegate(SetProgress), Progress);
            }
            else
            {
                PGBar.Value = Progress;
            }
        }

        static bool ReadXmlObject<T>(string FileName, out T NewObject)
        {
            try
            {
                XmlSerializer Serializer = new XmlSerializer(typeof(T));
                using (StreamReader Reader = new StreamReader(FileName))
                {
                    NewObject = (T)Serializer.Deserialize(Reader);
                }
                return true;
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Failed to read '{0}': {1}", FileName, Ex.ToString());
                NewObject = default(T);
                return false;
            }
        }
    }
}
