using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoNotes.Controls
{
    internal class MainMenuStrip : MenuStrip
    {
        public MainMenuStrip() 
        {
            Name = "MainMenuStrip";
            Dock = DockStyle.Top;

            FileDropDownMenu();
            EditDropDownMenu();
            FormatDropDownMenu();
            ViewDropDownMenu();
        }

        public void FileDropDownMenu()
        {
            var fileDropDownMenu = new ToolStripMenuItem("Fichier");

            var newMenu = new ToolStripMenuItem("Nouveau", null, null, Keys.Control | Keys.N);
            var openMenu = new ToolStripMenuItem("Ouvrir..", null, null, Keys.Control | Keys.O);
            var saveMenu = new ToolStripMenuItem("Enregister", null, null, Keys.Control | Keys.S);
            var saveAsMenu = new ToolStripMenuItem("Enregistrer sous..", null, null, Keys.Control | Keys.Shift | Keys.S);
            var quitMenu = new ToolStripMenuItem("Quitter", null, null, Keys.Alt | Keys.F4);

            fileDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { newMenu, openMenu, saveMenu, saveAsMenu, quitMenu });


            Items.Add(fileDropDownMenu);

        }

        public void EditDropDownMenu()
        {

            var editDropDownMenu = new ToolStripMenuItem("Edition");

            var cancelMenu = new ToolStripMenuItem("Annuler", null, null, Keys.Control | Keys.Z);
            var restoreMenu = new ToolStripMenuItem("Restaurer", null, null, Keys.Control | Keys.Y);

            editDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { cancelMenu, restoreMenu});


            Items.Add(editDropDownMenu);
        }

        public void FormatDropDownMenu()
        {
            var formatDropDownMenu = new ToolStripMenuItem("Format");

            var policeMenu = new ToolStripMenuItem("Police..");

            formatDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { policeMenu });


            Items.Add(formatDropDownMenu);
        }

        public void ViewDropDownMenu()
        {
            var viewDropDownMenu = new ToolStripMenuItem("Affichage");

            var alwaysFrontOfMenu = new ToolStripMenuItem("Rester devant");

            var zoomDropDownMenu = new ToolStripMenuItem("Menu zoom");
            var zoomInMenu = new ToolStripMenuItem("Zoomer", null, null, Keys.Control | Keys.Add);
            var zoomOutMenu = new ToolStripMenuItem("Dézoomer", null, null, Keys.Control | Keys.Subtract);
            var defaultZoomMenu = new ToolStripMenuItem("Zoom par défaut", null, null, Keys.Control | Keys.Divide);

            zoomInMenu.ShortcutKeyDisplayString = "Ctr+Num +";
            zoomOutMenu.ShortcutKeyDisplayString = "Ctr+Num -";
            defaultZoomMenu.ShortcutKeyDisplayString = "Ctr+Num /";


            zoomDropDownMenu.DropDownItems.AddRange (new ToolStripItem[] { zoomInMenu, zoomOutMenu, defaultZoomMenu });

            viewDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { alwaysFrontOfMenu, zoomDropDownMenu });


            Items.Add(viewDropDownMenu);
        }
    }
}
