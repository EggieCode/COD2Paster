using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using COD2Paster.Models;

namespace COD2Paster
{
    public partial class Form1 : Form
    {
        Paster pas = new Paster();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pas.PasteFile(File.ReadAllLines("log.log"));
            List<Damage> t = pas.Damages.Where(x => x.Victum.ID == x.Attacter.ID).ToList();


            dgvPlayers.DataSource = pas.Players;
        }

        private void buttonLoadLog_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {

                    pas.PasteFile(File.ReadAllLines(dialog.FileName));
                    dgvPlayers.DataSource = pas.Players;
                }
                catch
                {
                    MessageBox.Show("You need to select a COD2 Server log");
                }
            }  
        }

        private void cbOrderPlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbOrderPlist.SelectedIndex)
            {
                case 0:
                    dgvPlayers.DataSource = pas.Players.OrderByDescending(x => x.Team).ToList();
                    break;
                case 1:
                    dgvPlayers.DataSource = pas.Players.OrderBy(x => x.Team).ToList();
                    break;
                case 2:
                    dgvPlayers.DataSource = pas.Players.OrderByDescending(x => x.Playername).ToList();
                    break;
                case 3:
                    dgvPlayers.DataSource = pas.Players.OrderBy(x => x.Playername).ToList();
                    break;
                case 4:
                    dgvPlayers.DataSource = pas.Players.OrderByDescending(x => x.TotalKills).ToList();
                    break;
                case 5:
                    dgvPlayers.DataSource = pas.Players.OrderBy(x => x.TotalKills).ToList();
                    break;
                case 6:
                    dgvPlayers.DataSource = pas.Players.OrderByDescending(x => x.TotalDeads).ToList();
                    break;
                case 7:
                    dgvPlayers.DataSource = pas.Players.OrderBy(x => x.TotalDeads).ToList();
                    break;
            }

        }

        private void cbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*new object[] {
            "Rifles",0
            "Sniper rifles",1
            "Machine guns",2
            "Shotguns",3
            "Pistols",4
            "Grenades"}5
             * );*/
            COD2info info = new COD2info();
            switch (cbView.SelectedIndex)
            {
                case 0:
                    dgvStats.DataSource = pas.Players.Select(y =>
                    {
                        y.Total = pas.Damages.Where(x =>
                            x.Kill == true &&
                            x.Attacter.ID == y.ID && info.rifles.Exists(p => p == x.Weapon)
                        ).Count();
                        return y;
                    }).OrderByDescending(x => x.Total).ToList();

                    break;
                case 1:
                    dgvStats.DataSource = pas.Players.Select(y =>
                    {
                        y.Total = pas.Damages.Where(x =>
                            x.Kill == true &&
                            x.Attacter.ID == y.ID && info.sniper_rifles.Exists(p => p == x.Weapon)
                        ).Count();
                        return y;
                    }).OrderByDescending(x=>x.Total).ToList();
                    break;
                case 2: //Machine guns
                    dgvStats.DataSource = pas.Players.Select(y =>
                    {
                        y.Total = pas.Damages.Where(x =>
                            x.Kill == true &&
                            x.Attacter.ID == y.ID && info.machine_guns.Exists(p => p == x.Weapon)
                        ).Count();
                        return y;
                    }).OrderByDescending(x => x.Total).ToList();
                    break;
                case 3:
                    dgvStats.DataSource = pas.Players.Select(y =>
                    {
                        y.Total = pas.Damages.Where(x =>
                            x.Kill == true &&
                            x.Attacter.ID == y.ID && info.shotguns.Exists(p => p == x.Weapon)
                        ).Count();
                        return y;
                    }).OrderByDescending(x => x.Total).ToList();
                    break;
                case 4:
                    dgvStats.DataSource = pas.Players.Select(y =>
                    {
                        y.Total = pas.Damages.Where(x =>
                            x.Kill == true &&
                            x.Attacter.ID == y.ID && info.pistols.Exists(p => p == x.Weapon)
                        ).Count();
                        return y;
                    }).OrderByDescending(x => x.Total).ToList();
                    break;
                case 5:
                    dgvStats.DataSource = pas.Players.Select(y =>
                    {
                        y.Total = pas.Damages.Where(x =>
                            x.Kill == true &&
                            x.Attacter.ID == y.ID && info.grenades.Exists(p => p == x.Weapon)
                        ).Count();
                        return y;
                    }).OrderByDescending(x => x.Total).ToList();
                    break;

            }
        }


    }
}
