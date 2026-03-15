using s3molib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3mo
{
    partial class MainForm
    {
        private bool checkConflictBetweenModModelBackgroundWorker_restart = false;
        private bool checkConflictInModModelBackgroundWorker_restart = false;
        private bool checkDetailedConflictBetweenModModelBackgroundWorker_restart = false;

        private void CheckConflictsBetweenModModels()
        {
            if (checkConflictBetweenModModelBackgroundWorker.IsBusy)
            {
                checkConflictBetweenModModelBackgroundWorker_restart = true;
                checkConflictBetweenModModelBackgroundWorker.CancelAsync();
            }
            else
            {
                refreshButton.Enabled = false;
                modListView.Enabled = false;
                checkConflictBetweenModModelBackgroundWorker.RunWorkerAsync();
            }
        }

        private void checkConflictBetweenModModelBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (checkConflictBetweenModModelBackgroundWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            _profileModel.CheckModModelConflicts();
        }

        private void checkConflictBetweenModModelBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (checkConflictBetweenModModelBackgroundWorker_restart)
            {
                refreshButton.Enabled = false;
                modListView.Enabled = false;

                checkConflictBetweenModModelBackgroundWorker_restart = false;
                checkConflictBetweenModModelBackgroundWorker.RunWorkerAsync();
            }
            else
            {
                modListView.Enabled = true;
                modListView.Refresh();

                if (!checkConflictInModModelBackgroundWorker.IsBusy)
                    refreshButton.Enabled = true;

                Invoke(CheckDetailedConflictsBetweenModModels);
                Logger.Log("Finished fast conflict checking between mods.");
            }
        }



        private void CheckConflictsInModModels()
        {
            if (checkConflictInModModelBackgroundWorker.IsBusy)
            {
                checkConflictInModModelBackgroundWorker_restart = true;
                checkConflictInModModelBackgroundWorker.CancelAsync();
            }
            else
            {
                refreshButton.Enabled = false;
                fileListView.Enabled = false;
                checkConflictInModModelBackgroundWorker.RunWorkerAsync();
            }
        }

        private void checkConflictInModModelBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (checkConflictInModModelBackgroundWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            _profileModel.CheckPackageConflicts();
        }

        private void checkConflictInModModelBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (checkConflictInModModelBackgroundWorker_restart)
            {
                checkConflictBetweenModModelBackgroundWorker_restart = false;
                checkConflictBetweenModModelBackgroundWorker.RunWorkerAsync();
            }
            else
            {
                fileListView.Enabled = true;
                fileListView.Refresh();

                if (!checkConflictInModModelBackgroundWorker.IsBusy)
                    refreshButton.Enabled = true;

                Logger.Log("Finished conflict checking in mods.");
            }
        }



        private void CheckDetailedConflictsBetweenModModels()
        {
            if (checkDetailedConflictBetweenModModelBackgroundWorker.IsBusy)
            {
                checkDetailedConflictBetweenModModelBackgroundWorker_restart = true;
                checkDetailedConflictBetweenModModelBackgroundWorker.CancelAsync();
            }
            else
                checkDetailedConflictBetweenModModelBackgroundWorker.RunWorkerAsync();
        }

        private void checkDetailedConflictBetweenModModelBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (checkDetailedConflictBetweenModModelBackgroundWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            _profileModel.CheckDetailedConflicts();
        }

        private void checkDetailedConflictBetweenModModelBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (checkDetailedConflictBetweenModModelBackgroundWorker_restart)
            {
                checkDetailedConflictBetweenModModelBackgroundWorker_restart = false;
                checkDetailedConflictBetweenModModelBackgroundWorker.RunWorkerAsync();
            }
            else
            {
                Logger.Log("Finished detailed conflict checking between mods.");
            }
        }
    }
}
