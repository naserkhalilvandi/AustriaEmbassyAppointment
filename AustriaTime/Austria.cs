
namespace AustriaTime
{
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium;
    using System.Windows.Forms;
    public partial class Austria : Form
    {
        private Timer t;
        public Austria()
        {
            InitializeComponent();
            t = new Timer();
            t.Interval = Convert.ToInt32(txtTimer.Text); ; 
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }
        FirefoxDriver driver;
        private void timer_Tick(object? sender, EventArgs e)
        {
            t.Interval=Convert.ToInt32(txtTimer.Text);
            if (!chkStart.Checked)
            {
                return;
            }

            //var driver = new ChromeDriver();
           if(driver != null)
            {
                driver.Quit();
            }
            driver = new FirefoxDriver();
            
            try
            {

                // step 1 open website
                driver.Navigate().GoToUrl("https://appointment.bmeia.gv.at/");
                //Thread.Sleep(500);

                //step 2 
                var button = driver.FindElement(By.Id("Office"));
                button.Click();

                //step 3
                //Thread.Sleep(500);
                var button2 = driver.FindElements(By.TagName("option"));
                button2.FirstOrDefault(c => c.Text == "TEHERAN").Click();

                //step4
                //Command
                //Thread.Sleep(400);
                var button3 = driver.FindElement(By.Name("Command"));
                button3.Click();

                //step 5
                //Jobseeker
                //Thread.Sleep(400);
                var button4 = driver.FindElements(By.TagName("option"));
                button4.FirstOrDefault(c => c.Text == "Jobseeker").Click();


                // step 6
               // Thread.Sleep(400);
                var button5 = driver.FindElements(By.Name("Command"));
                button5[2].Click();

                // step 7
                //Thread.Sleep(400);
                var button6 = driver.FindElements(By.Name("Command"));
                button6[2].Click();

                // step 8
                //Thread.Sleep(400);
                var button7 = driver.FindElements(By.Name("Command"));
                button7[1].Click();

                // step 9
                
                //Thread.Sleep(500);
                var button8 = driver.FindElements(By.TagName("p"))
                    .FirstOrDefault(c => c.Text == "For your selection there are unfortunately no appointments available");

                if (button8 == null)
                {

                    alert();
                }
                //Thread.Sleep(500);

             //   driver.Quit();


            }
            catch
            {
                Thread.Sleep(500);
             //   driver.Quit();
            }
        }

        private void alert()
        {
            sms.Send(["09199508849"]);
            // site is open
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\NOTDIR\alert.wav");
            for (int i = 0; i < 50; i++)
            {
                player.Play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alert();
        }
    }
}
