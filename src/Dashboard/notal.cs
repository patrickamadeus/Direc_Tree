class MainForm():
    procedure StartDirectory_Click(input/output DirTextInput)
        KAMUS LOKAL
            openFileDialog : CommonFileDialog
        ALGORITMA
            openFileDialog.IsFolderPicker <- true;
            if (openFileDialog.ShowDialog() = CommonFileDialogResult.Ok) then
                DirTextInput.Text <- openFileDialog.FileName;

    procedure SearchButton_Click(input/output WarningLabel : string,  
    input BFSbutton, DFSbutton, AllOccurence :  
    bool , FoundDirs : ListBox, GraphPanel : Panel , TimeSpentText : Label)
        KAMUS LOKAL
            g <- Graph
            ndoes <- map(string,int)
            foundPath <- array of string
            stopwatch <- Stopwatch
        ALGORITMA
            if ((not BFSbutton && not DFSbutton) || DirTextInput.Text = "" || FileInput.Text = "") then
                WarningLabel.Text <- "";
                {sleep 20 detik}
                WarningLabel.Text <- "Please fill in required fields";
            else

                WarningLabel.Text <- "";

                // Clearing Old Output(s)
                FoundDirs.Items <- nil
                GraphPanel.Controls <- nil;

                nodes <- {}
                foundPath <- []
                if (BFSbutton) then
                    {stopwatch mulai}
                    nodes <- BFSsearching(AllOccurence, DirTextInput.Text, FileInput.Text, foundPath);
                    {stopwatch berakhir}
                else
                    {stopwatch mulai}
                    nodes <- DFSsearching(AllOccurence, DirTextInput.Text, FileInput.Text, foundPath);
                    {stopwatch berakhir}

                GraphPanel.Controls.Add(ShowGraph(nodes, BFSbutton));


                for path in foundPath
                    FoundDirs <- FoundDirs + path
                
                TimeSpentText.Text <- "Time Spent: " + {detik proses} +"s";


    procedure FoundDirs_SelectedIndexChanged(object sender, EventArgs e)
        KAMUS LOKAL
            -
        ALGORITMA
            {launch file explorer sesuai dengan pilihan file}

