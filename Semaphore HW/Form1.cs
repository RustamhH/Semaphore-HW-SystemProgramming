using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Semaphore_HW
{
    public partial class Form1 : Form
    {

        public List<Thread> Created { get; set; } = new();
        public List<Thread> Waiting { get; set; }=new();
        public List<Thread> Working { get; set; } = new();
        public bool Check { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            // yeni thread yaradilir ve created e elave olunur.
            Thread thread = new Thread(SomeMethod);
            Created.Add(thread);
            CreatedThreadsList.Items.Add("Thread "+thread.ManagedThreadId);
        }






        void SomeMethod(object? state)
        {
            var semaphore = state as Semaphore;

            if (semaphore is null)
                return;


            bool isFinish = false;

            while (!isFinish)
            {
                if (semaphore.WaitOne(2000))
                {
                    Thread.Sleep(3000);
                    int id = Thread.CurrentThread.ManagedThreadId;
                    try
                    {
                        Working.Add(Thread.CurrentThread);
                        Waiting.Remove(Thread.CurrentThread);
                        if(WorkingThreadsList.InvokeRequired)
                        {
                            Action invoker = delegate { WorkingThreadsList.Items.Add("Thread " + id); };
                            WorkingThreadsList.Invoke(invoker);
                        }
                        if(WaitingThreadsList.InvokeRequired)
                        {
                            Action invoker = delegate { WaitingThreadsList.Items.Remove("Thread " + id); };
                            WaitingThreadsList.Invoke(invoker);
                        }
                        
                        Thread.Sleep(6000);
                    }
                    finally
                    {
                        Working.Remove(Thread.CurrentThread);
                        if (WorkingThreadsList.InvokeRequired)
                        {
                            Action invoker = delegate { WorkingThreadsList.Items.Remove("Thread " + id); };
                            WorkingThreadsList.Invoke(invoker);
                        }
                        isFinish = true;
                        semaphore.Release();
                    }
                }
                else
                {
                    
                }
            }
        }

        private void CreatedThreadsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Check==true)
            {
                Check = false;
                return;
            }
            if(sender is ListBox lb)
            {
                string selecteditem = lb.Text;
                int selectedthreadid=Convert.ToInt32(selecteditem.Substring(selecteditem.IndexOf(" ")+1));
                // secilmis thread waiting e elave olunacaq , created den silinecek
                foreach (var item in Created)
                {
                    if (item.ManagedThreadId == selectedthreadid)
                    {
                        Waiting.Add(item);
                        Created.Remove(item);
                        WaitingThreadsList.Items.Add("Thread " + item.ManagedThreadId);
                        Check = true;
                        item.Start(new Semaphore(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown1.Value)));
                        CreatedThreadsList.Items.Remove("Thread " + item.ManagedThreadId);
                        return;
                    };
                }
            }

        }
    }
}