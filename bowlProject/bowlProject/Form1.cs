using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Joshua Williams
 * Period: 0
 * Date: 12/16/14
 * Project Desc: This is a program for the 2015 Sugar Bowl between Ohio
 * State and Alabama. It gives each team's previous bowl history, 2014 schedule,
 * and a little background on each school. */

namespace bowlProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radOhioState_CheckedChanged(object sender, EventArgs e)
        {
            picAlabamaBig.Visible = false;
            picAlabamaSmall.Visible = true;
            picOhioBig.Visible = true;
            picOhioSmall.Visible = false;
        }

        private void radAlabama_CheckedChanged(object sender, EventArgs e)
        {
            picAlabamaBig.Visible = true;
            picAlabamaSmall.Visible = false;
            picOhioBig.Visible = false;
            picOhioSmall.Visible = true;
        }

        private void cboOhioState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOhioState.SelectedIndex == 0)
            {
                lblOhioOutput.Text = "1921 Rose Bowl" + "\n" + "vs California Golden Bears"
                    + "\n" + "L 28-0";
            }
            else if (cboOhioState.SelectedIndex == 1)
            {
                lblOhioOutput.Text = "1950 Rose Bowl" + "\n" + "vs California Golden Bears"
                    + "\n" + "W 17-14";
            }
            else if (cboOhioState.SelectedIndex == 2)
            {
                lblOhioOutput.Text = "1955 Rose Bowl" + "\n" + "vs USC Trojans"
                    + "\n" + "W 20-7";
            }
            else if (cboOhioState.SelectedIndex == 3)
            {
                lblOhioOutput.Text = "1958 Rose Bowl" + "\n" + "vs Oregan Ducks" + "\n"
                    + "W 10-7";
            }
            else if (cboOhioState.SelectedIndex == 4)
            {
                lblOhioOutput.Text = "1969 Rose Bowl" + "\n" + "vs USC Trojans" + "\n"
                    + "W 27-16";
            }
            else if (cboOhioState.SelectedIndex == 5)
            {
                lblOhioOutput.Text = "1971 Rose Bowl" + "\n" + "vs Stanford Indians" + "\n"
                    + "L 27-17";
            }
            else if (cboOhioState.SelectedIndex == 6)
            {
                lblOhioOutput.Text = "1973 Rose Bowl" + "\n" + "vs USC Trojans" + "\n"
                    + "L 42-17";
            }
            else if (cboOhioState.SelectedIndex == 7)
            {
                lblOhioOutput.Text = "1974 Rose Bowl" + "\n" + "vs USC Trojans" + "\n"
                    + "W 42-21";
            }
            else if (cboOhioState.SelectedIndex == 8)
            {
                lblOhioOutput.Text = "1975 Rose Bowl" + "\n" + "vs USC Trojans" + "\n"
                    + "L 18-17";
            }
            else if (cboOhioState.SelectedIndex == 9)
            {
                lblOhioOutput.Text = "1976 Rose Bowl" + "\n" + "vs UCLA Bruins" + "\n"
                    + "L 23-10";
            }
            else if (cboOhioState.SelectedIndex == 10)
            {
                lblOhioOutput.Text = "1977 Orange Bowl" + "\n" + "vs Colorade Buffaloes" + "\n"
                    + "W 27-10";
            }
            else if (cboOhioState.SelectedIndex == 11)
            {
                lblOhioOutput.Text = "1978 Sugar Bowl" + "\n" + "vs Alabama Crimson Tide" + "\n"
                    + "L 35-6";
            }
            else if (cboOhioState.SelectedIndex == 12)
            {
                lblOhioOutput.Text = "1978 Gator Bowl" + "\n" + "vs Clemson Tigers" + "\n"
                    + "L 17-15";
            }
            else if (cboOhioState.SelectedIndex == 13)
            {
                lblOhioOutput.Text = "1980 Rose Bowl" + "\n" + "vs USC Trojans" + "\n"
                    + "L 17-16";
            }
            else if (cboOhioState.SelectedIndex == 14)
            {
                lblOhioOutput.Text = "1980 Fiesta Bowl" + "\n" + "vs Penn State Nittany Lions" + "\n"
                    + "L 31-19";
            }
            else if (cboOhioState.SelectedIndex == 15)
            {
                lblOhioOutput.Text = "1981 Liberty Bowl" + "\n" + "vs Navy Midshipmen" + "\n"
                    + "W 31-28";
            }
            else if (cboOhioState.SelectedIndex == 16)
            {
                lblOhioOutput.Text = "1982 Holiday Bowl" + "\n" + "vs BYU Cougars" + "\n"
                    + "W 47-17";
            }
            else if (cboOhioState.SelectedIndex == 17)
            {
                lblOhioOutput.Text = "1984 Fiesta Bowl" + "\n" + "vs Pittsburgh Panthers" + "\n"
                    + "W 28-23";
            }
            else if (cboOhioState.SelectedIndex == 18)
            {
                lblOhioOutput.Text = "1985 Rose Bowl" + "\n" + "vs USC Trojans" + "\n"
                    + "L 20-17";
            }
            else if (cboOhioState.SelectedIndex == 19)
            {
                lblOhioOutput.Text = "1985 Citrus Bowl" + "\n" + "vs BYU Cougars" + "\n"
                    + "W 10-7";
            }
            else if (cboOhioState.SelectedIndex == 20)
            {
                lblOhioOutput.Text = "1987 Cotton Bowl Classic" + "\n" + "vs Texas A&M Aggies" + "\n"
                    + "W 28-12";
            }
            else if (cboOhioState.SelectedIndex == 21)
            {
                lblOhioOutput.Text = "1990 Hall of Fame Bowl" + "\n" + "vs Auburn Tigers" + "\n"
                    + "L 31-14";
            }
            else if (cboOhioState.SelectedIndex == 22)
            {
                lblOhioOutput.Text = "1990 Liberty Bowl" + "\n" + "vs Air Force Falcons" + "\n"
                    + "L 23-11";
            }
            else if (cboOhioState.SelectedIndex == 23)
            {
                lblOhioOutput.Text = "1992 Hall fo Fame Bowl" + "\n" + "vs Syracuse Orangemen" + "\n"
                    + "L 24-17";
            }
            else if (cboOhioState.SelectedIndex == 24)
            {
                lblOhioOutput.Text = "1993 Citrus Bowl" + "\n" + "vs Georgia Bulldogs" + "\n"
                    + "L 21-14";
            }
            else if (cboOhioState.SelectedIndex == 25)
            {
                lblOhioOutput.Text = "1993 Holiday Bowl" + "\n" + "vs BYU Cougars" + "\n"
                    + "W 28-21";
            }
            else if (cboOhioState.SelectedIndex == 26)
            {
                lblOhioOutput.Text = "1995 Citrus Bowl" + "\n" + "vs Alabama Crimson Tide" + "\n"
                    + "L 24-17";
            }
            else if (cboOhioState.SelectedIndex == 27)
            {
                lblOhioOutput.Text = "1996 Citrus Bowl" + "\n" + "vs Tennessee Volunteers" + "\n"
                    + "L 20-15";
            }
            else if (cboOhioState.SelectedIndex == 28)
            {
                lblOhioOutput.Text = "1997 Rose Bowl" + "\n" + "vs Arizona State Sun Devils" + "\n"
                    + "W 20-17";
            }
            else if (cboOhioState.SelectedIndex == 29)
            {
                lblOhioOutput.Text = "1998 Sugar Bowl" + "\n" + "vs Florida State Seminoles" + "\n"
                    + "L 31-14";
            }
            else if (cboOhioState.SelectedIndex == 30)
            {
                lblOhioOutput.Text = "1999 Sugar Bowl" + "\n" + "vs Texas A&M Aggies" + "\n"
                    + "W 24-14";
            }
            else if (cboOhioState.SelectedIndex == 31)
            {
                lblOhioOutput.Text = "2001 Outback Bowl" + "\n" + "vs South Carolina Gamecocks" + "\n"
                    + "L 24-7";
            }
            else if (cboOhioState.SelectedIndex == 32)
            {
                lblOhioOutput.Text = "2002 Outback Bowl" + "\n" + "vs South Carolina Gamecocks" + "\n"
                    + "L 31-28";
            }
            else if (cboOhioState.SelectedIndex == 33)
            {
                lblOhioOutput.Text = "2003 Fiesta Bowl" + "\n" + "vs Miami Hurricanes" + "\n"
                    + "W 31-24";
            }
            else if (cboOhioState.SelectedIndex == 34)
            {
                lblOhioOutput.Text = "2004 Fiesta Bowl" + "\n" + "vs Kansas State Wildcats" + "\n"
                    + "W 35-28";
            }
            else if (cboOhioState.SelectedIndex == 35)
            {
                lblOhioOutput.Text = "2004 Alamo Bowl" + "\n" + "vs Oklahoma State Cowboys" + "\n"
                    + "W 33-6";
            }
            else if (cboOhioState.SelectedIndex == 36)
            {
                lblOhioOutput.Text = "2006 Fiesta Bowl" + "\n" + "vs Notre Dame Fighting Irish" + "\n"
                    + "W 34-20";
            }
            else if (cboOhioState.SelectedIndex == 37)
            {
                lblOhioOutput.Text = "2007 BCS National Championship Game" + "\n" + "vs Florida Gators" + "\n"
                    + "L 41-14";
            }
            else if (cboOhioState.SelectedIndex == 38)
            {
                lblOhioOutput.Text = "2008 BCS National Championship Game" + "\n" + "vs LSU Tigers" + "\n"
                    + "L 38-24";
            }
            else if (cboOhioState.SelectedIndex == 39)
            {
                lblOhioOutput.Text = "2009 Fiesta Bowl" + "\n" + "vs Texas Longhorns" + "\n"
                    + "L 24-21";
            }
            else if (cboOhioState.SelectedIndex == 40)
            {
                lblOhioOutput.Text = "2010 Rose Bowl" + "\n" + "vs Oregon Ducks" + "\n"
                    + "W 26-17";
            }
            else if (cboOhioState.SelectedIndex == 41)
            {
                lblOhioOutput.Text = "2011 Sugar Bowl" + "\n" + "vs Arkansas Razorbacks" + "\n"
                    + "W 31-26";
            }
            else if (cboOhioState.SelectedIndex == 42)
            {
                lblOhioOutput.Text = "2012 Gator Bowl" + "\n" + "vs Florida Gators" + "\n"
                    + "L 24-17";
            }
            else if (cboOhioState.SelectedIndex == 43)
            {
                lblOhioOutput.Text = "2014 Orange Bowl" + "\n" + "vs Clemson Tigers" + "\n"
                    + "L 40-35";
            }
            else if (cboOhioState.SelectedIndex == 44)
            {
                lblOhioOutput.Text = "2015 Sugar Bowl" + "\n" + "vs Alabama Crimson Tide" + "\n"
                    + "TBD";
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbxSchedules.SelectedIndex == 0)
            {
                frmOhioStateSchedule ohioStateSchedule = new frmOhioStateSchedule();
                ohioStateSchedule.ShowDialog();
            }
            else if (lbxSchedules.SelectedIndex == 1)
            {
                frmAlabamaSchedule alabamaSchedule = new frmAlabamaSchedule();
                alabamaSchedule.ShowDialog();
            }
        }

        private void cboAlabama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAlabama.SelectedIndex == 0)
            {
                lblAlabamaOutput.Text =
                    "1926 Rose Bowl" + "\n" +
                    "vs Washington Huskies" + "\n" +
                    "W 20-19";
            }
            else if (cboAlabama.SelectedIndex == 1)
            {
                lblAlabamaOutput.Text =
                    "1927 Rose Bowl" + "\n" +
                    "vs Stanford" + "\n" +
                    "T 7-7";
            }
            else if (cboAlabama.SelectedIndex == 2)
            {
                lblAlabamaOutput.Text =
                    "1931 Rose Bowl" + "\n" +
                    "vs Washington State Cougars" + "\n" +
                    "W 24-0";
            }
            else if (cboAlabama.SelectedIndex == 3)
            {
                lblAlabamaOutput.Text =
                    "1935 Rose Bowl" + "\n" +
                    "vs Stanford Indians" + "\n" +
                    "W 29-13";
            }
            else if (cboAlabama.SelectedIndex == 4)
            {
                lblAlabamaOutput.Text =
                    "1938 Rose Bowl" + "\n" +
                    "vs California Golden Bears" + "\n" +
                    "L 13-0";
            }
            else if (cboAlabama.SelectedIndex == 5)
            {
                lblAlabamaOutput.Text =
                    "1942 Cotton Bowl Classic" + "\n" +
                    "vs Texas A&M Aggies" + "\n" +
                    "W 29-21";
            }
            else if (cboAlabama.SelectedIndex == 6)
            {
                lblAlabamaOutput.Text =
                    "1943 Orange Bowl" + "\n" +
                    "vs Boston College Eagles" + "\n" +
                    "W 37-21";
            }
            else if (cboAlabama.SelectedIndex == 7)
            {
                lblAlabamaOutput.Text =
                    "1945 Sugar Bowl" + "\n" +
                    "vs Duke Blue Devils" + "\n" +
                    "L 29-26";
            }
            else if (cboAlabama.SelectedIndex == 8)
            {
                lblAlabamaOutput.Text =
                    "1927 Rose Bowl" + "\n" +
                    "vs Stanford" + "\n" +
                    "T 7-7";
            }
            else if (cboAlabama.SelectedIndex == 9)
            {
                lblAlabamaOutput.Text =
                    "1948 Sugar Bowl" + "\n" +
                    "vs Texas Longhorns" + "\n" +
                    "L 27-7";
            }
            else if (cboAlabama.SelectedIndex == 10)
            {
                lblAlabamaOutput.Text =
                    "1953 Orange Bowl" + "\n" +
                    "vs Syracuse Orangemen" + "\n" +
                    "W 61-6";
            }
            else if (cboAlabama.SelectedIndex == 11)
            {
                lblAlabamaOutput.Text =
                    "1954 Cotton Bowl Classic" + "\n" +
                    "vs Rice Owls" + "\n" +
                    "L 28-6";
            }
            else if (cboAlabama.SelectedIndex == 12)
            {
                lblAlabamaOutput.Text =
                    "1959 Liberty Bowl" + "\n" +
                    "vs Penn State Nittany Lions" + "\n" +
                    "L 7-0";
            }
            else if (cboAlabama.SelectedIndex == 13)
            {
                lblAlabamaOutput.Text =
                    "1960 BLuebonnet Bowl" + "\n" +
                    "vs Texas Longhorns" + "\n" +
                    "T 3-3";
            }
            else if (cboAlabama.SelectedIndex == 14)
            {
                lblAlabamaOutput.Text =
                    "1962 Sugar Bowl" + "\n" +
                    "vs Arkansas Razorbacks" + "\n" +
                    "W 10-3";
            }
            else if (cboAlabama.SelectedIndex == 15)
            {
                lblAlabamaOutput.Text =
                    "1963 Orange Bowl" + "\n" +
                    "vs Oklahoma Sooners" + "\n" +
                    "W 17-0";
            }
            else if (cboAlabama.SelectedIndex == 16)
            {
                lblAlabamaOutput.Text =
                    "1964 Sugar Bowl" + "\n" +
                    "vs Ole Miss Rebels" + "\n" +
                    "W 12-7";
            }
            else if (cboAlabama.SelectedIndex == 17)
            {
                lblAlabamaOutput.Text =
                    "1965 Orange Bowl" + "\n" +
                    "vs Texas Longhorns" + "\n" +
                    "L 21-17";
            }
            else if (cboAlabama.SelectedIndex == 18)
            {
                lblAlabamaOutput.Text =
                    "1966 Orange Bowl" + "\n" +
                    "vs Nebraska Cornhuskers" + "\n" +
                    "W 39-28";
            }
            else if (cboAlabama.SelectedIndex == 19)
            {
                lblAlabamaOutput.Text =
                    "1967 Sugar Bowl" + "\n" +
                    "vs Nebraska Cornhuskers" + "\n" +
                    "W 34-7";
            }
            else if (cboAlabama.SelectedIndex == 20)
            {
                lblAlabamaOutput.Text =
                    "1968 Cotton Bowl Classic" + "\n" +
                    "vs Texas A&M Aggies" + "\n" +
                    "L 20-16";
            }
            else if (cboAlabama.SelectedIndex == 21)
            {
                lblAlabamaOutput.Text =
                    "1968 Gator Bowl" + "\n" +
                    "vs Missouri Tigers" + "\n" +
                    "L 35-10";
            }
            else if (cboAlabama.SelectedIndex == 22)
            {
                lblAlabamaOutput.Text =
                    "1969 Liberty Bowl" + "\n" +
                    "vs Colorado Buffaloes" + "\n" +
                    "L 47-33";
            }
            else if (cboAlabama.SelectedIndex == 23)
            {
                lblAlabamaOutput.Text =
                    "1970 Bluebonnet Bowl" + "\n" +
                    "vs Oklahoma Sooners" + "\n" +
                    "T 24-24";
            }
            else if (cboAlabama.SelectedIndex == 24)
            {
                lblAlabamaOutput.Text =
                    "1972 Orange Bowl" + "\n" +
                    "vs Nebraska Cornhuskers" + "\n" +
                    "L 38-6";
            }
            else if (cboAlabama.SelectedIndex == 25)
            {
                lblAlabamaOutput.Text =
                    "1973 Cotton Bowl Classic" + "\n" +
                    "vs Texas Longhorns" + "\n" +
                    "L 17-13";
            }
            else if (cboAlabama.SelectedIndex == 26)
            {
                lblAlabamaOutput.Text =
                    "1973 Sugar Bowl" + "\n" +
                    "vs Notre Dame Fighting Irish" + "\n" +
                    "L 24-23";
            }
            else if (cboAlabama.SelectedIndex == 27)
            {
                lblAlabamaOutput.Text =
                    "1975 Orange Bowl" + "\n" +
                    "vs Notre Dame Fighting Irish" + "\n" +
                    "L 13-11";
            }
            else if (cboAlabama.SelectedIndex == 28)
            {
                lblAlabamaOutput.Text =
                    "1975 Sugar Bowl" + "\n" +
                    "vs Penn State Nittany Lions" + "\n" +
                    "W 13-6";
            }
            else if (cboAlabama.SelectedIndex == 29)
            {
                lblAlabamaOutput.Text =
                    "1976 Liberty Bowl" + "\n" +
                    "vs UCLA Bruins" + "\n" +
                    "W 36-6";
            }
            else if (cboAlabama.SelectedIndex == 30)
            {
                lblAlabamaOutput.Text =
                    "1978 Sugar Bowl" + "\n" +
                    "vs Ohio State Buckeyes" + "\n" +
                    "W 35-6";
            }
            else if (cboAlabama.SelectedIndex == 31)
            {
                lblAlabamaOutput.Text =
                    "1979 Sugar Bowl" + "\n" +
                    "vs Penn State Nittany Lions" + "\n" +
                    "W 14-7";
            }
            else if (cboAlabama.SelectedIndex == 32)
            {
                lblAlabamaOutput.Text =
                    "1980 Sugar Bowl" + "\n" +
                    "vs Arkansas Razorbacks" + "\n" +
                    "W 24-9";
            }
            else if (cboAlabama.SelectedIndex == 33)
            {
                lblAlabamaOutput.Text =
                    "1981 Cotton Bowl Classic" + "\n" +
                    "vs Baylor Bears" + "\n" +
                    "W 30-2";
            }
            else if (cboAlabama.SelectedIndex == 34)
            {
                lblAlabamaOutput.Text =
                    "1982 Cotton Bowl Classic" + "\n" +
                    "vs Texas Longhorns" + "\n" +
                    "L 14-12";
            }
            else if (cboAlabama.SelectedIndex == 35)
            {
                lblAlabamaOutput.Text =
                    "1982 Liberty Bowl" + "\n" +
                    "vs Illinois Fighting Illini" + "\n" +
                    "W 21-15";
            }
            else if (cboAlabama.SelectedIndex == 36)
            {
                lblAlabamaOutput.Text =
                    "1983 Sun Bowl" + "\n" +
                    "vs SMU Mustangs" + "\n" +
                    "W 28-7";
            }
            else if (cboAlabama.SelectedIndex == 37)
            {
                lblAlabamaOutput.Text =
                    "1985 Aloha Bowl" + "\n" +
                    "vs USC Trojans" + "\n" +
                    "W 24-3";
            }
            else if (cboAlabama.SelectedIndex == 38)
            {
                lblAlabamaOutput.Text =
                    "1986 Sun Bowl" + "\n" +
                    "vs Washington Huskies" + "\n" +
                    "W 28-6";
            }
            else if (cboAlabama.SelectedIndex == 39)
            {
                lblAlabamaOutput.Text =
                    "1988 Hall of Fame Bowl" + "\n" +
                    "vs Michigan Wolverines" + "\n" +
                    "L 28-24";
            }
            else if (cboAlabama.SelectedIndex == 40)
            {
                lblAlabamaOutput.Text =
                    "1988 Sun Bowl" + "\n" +
                    "vs Army Black Knights" + "\n" +
                    "W 29-28";
            }
            else if (cboAlabama.SelectedIndex == 41)
            {
                lblAlabamaOutput.Text =
                    "1990 Sugar Bowl" + "\n" +
                    "vs Miami Hurricanes" + "\n" +
                    "L 33-25";
            }
            else if (cboAlabama.SelectedIndex == 42)
            {
                lblAlabamaOutput.Text =
                    "1991 Fiesta Bowl" + "\n" +
                    "vs Louisville Cardinals" + "\n" +
                    "L 34-7";
            }
            else if (cboAlabama.SelectedIndex == 43)
            {
                lblAlabamaOutput.Text =
                    "1991 Blockbuster Bowl" + "\n" +
                    "vs Colorado Buffaloes" + "\n" +
                    "W 30-25";
            }
            else if (cboAlabama.SelectedIndex == 44)
            {
                lblAlabamaOutput.Text =
                    "1993 Sugar Bowl" + "\n" +
                    "vs Miami Hurricans" + "\n" +
                    "W 34-13";
            }
            else if (cboAlabama.SelectedIndex == 45)
            {
                lblAlabamaOutput.Text =
                    "1993 Gator Bowl" + "\n" +
                    "vs North Carolina Tar Heels" + "\n" +
                    "W 24-10";
            }
            else if (cboAlabama.SelectedIndex == 46)
            {
                lblAlabamaOutput.Text =
                    "1995 Citrus Bowl" + "\n" +
                    "vs Ohio State Buckeyes" + "\n" +
                    "W 24-17";
            }
            else if (cboAlabama.SelectedIndex == 47)
            {
                lblAlabamaOutput.Text =
                    "1997 Outback Bowl" + "\n" +
                    "vs Michigan Wolverines" + "\n" +
                    "W 17-14";
            }
            else if (cboAlabama.SelectedIndex == 48)
            {
                lblAlabamaOutput.Text =
                    "1998 Music City Bowl" + "\n" +
                    "vs Virginia Tech Hokies" + "\n" +
                    "W 38-7";
            }
            else if (cboAlabama.SelectedIndex == 49)
            {
                lblAlabamaOutput.Text =
                    "2000 Orange Bowl" + "\n" +
                    "vs Michigan Wolverines" + "\n" +
                    "L 35-34";
            }
            else if (cboAlabama.SelectedIndex == 50)
            {
                lblAlabamaOutput.Text =
                    "2001 Independence Bowl" + "\n" +
                    "vs Iowa State Cyclones" + "\n" +
                    "W 14-13";
            }
            else if (cboAlabama.SelectedIndex == 51)
            {
                lblAlabamaOutput.Text =
                    "2004 Music Citry Bowl" + "\n" +
                    "vs Minnesota Golden Gophers" + "\n" +
                    "L 20-16";
            }
            else if (cboAlabama.SelectedIndex == 52)
            {
                lblAlabamaOutput.Text =
                    "2006 Cotton Bowl Classic" + "\n" +
                    "vs Texas Tech Red Raiders" + "\n" +
                    "W 13-10";
            }
            else if (cboAlabama.SelectedIndex == 53)
            {
                lblAlabamaOutput.Text =
                    "2006 Independence Bowl" + "\n" +
                    "vs Oklahoma State Cowboys" + "\n" +
                    "L 34-31";
            }
            else if (cboAlabama.SelectedIndex == 54)
            {
                lblAlabamaOutput.Text =
                    "2007 Independence Bowl" + "\n" +
                    "vs Colorado Buffaloes" + "\n" +
                    "W 30-24";
            }
            else if (cboAlabama.SelectedIndex == 55)
            {
                lblAlabamaOutput.Text =
                    "2009 Sugar Bowl" + "\n" +
                    "vs Utah Utes" + "\n" +
                    "L 31-17";
            }
            else if (cboAlabama.SelectedIndex == 56)
            {
                lblAlabamaOutput.Text =
                    "2010 BCS National Championship Game" + "\n" +
                    "vs Texas Longhorns" + "\n" +
                    "W 37-21";
            }
            else if (cboAlabama.SelectedIndex == 57)
            {
                lblAlabamaOutput.Text =
                    "2011 Capital One Bowl" + "\n" +
                    "vs Michigan State Spartans" + "\n" +
                    "W 49-7";
            }
            else if (cboAlabama.SelectedIndex == 58)
            {
                lblAlabamaOutput.Text =
                    "2012 BCS National Championship Game" + "\n" +
                    "vs LSU Tigers" + "\n" +
                    "W 21-0";
            }
            else if (cboAlabama.SelectedIndex == 59)
            {
                lblAlabamaOutput.Text =
                    "2013 BCS National Championship Game" + "\n" +
                    "vs Notre Dame Fighting Irish" + "\n" +
                    "W 42-14";
            }
            else if (cboAlabama.SelectedIndex == 60)
            {
                lblAlabamaOutput.Text =
                    "2014 Sugar Bowl" + "\n" +
                    "vs Oklahoma Sooners" + "\n" +
                    "L 45-31";
            }
            else if (cboAlabama.SelectedIndex == 61)
            {
                lblAlabamaOutput.Text =
                    "2015 Sugar Bowl" + "\n" +
                    "vs Ohio State Buckeyes" + "\n" +
                    "TBD";
            }
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I think that Alabama will win 17-14." + "\n" +
                "Alabama has one of the best defenses in the country, " +
                "as well as a very strong offense, and Ohio State has a third " +
                "string quarterback playing.");
        }

        private void schoolInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutOhioState aboutOhioState = new frmAboutOhioState();
            aboutOhioState.ShowDialog();
        }

        private void alToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutAlabama aboutAlabama = new frmAboutAlabama();
            aboutAlabama.ShowDialog();
        }
    }
}
