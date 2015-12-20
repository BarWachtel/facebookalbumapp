using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DesignPatternsEx01
{
    class AlbumSaver
    {
        public static void SaveAlbum(string i_AlbumId)
        {
            string fileDirectoryPath = FolderBrowser.SelectOrCreateFolder();

            Album selectedAlbum = null;
            if (!string.IsNullOrEmpty(fileDirectoryPath))
            {
                selectedAlbum = FacebookUser.GetInstance().GetAlbumById(i_AlbumId);

                if (selectedAlbum != null)
                {
                    AlbumSaverProgress albumSaverProgress = new AlbumSaverProgress(selectedAlbum.Photos.Count);
                    albumSaverProgress.Show();

                    int imgName = 0;
                    new Thread(() =>
                        {
                            foreach (Photo photo in selectedAlbum.Photos)
                            {
                                System.Drawing.Imaging.ImageFormat imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                string photoName =
                                    string.Format(@"{0}{1}{2}_{3}.{4}", fileDirectoryPath, System.IO.Path.DirectorySeparatorChar, selectedAlbum.Name, imgName.ToString(), imageFormat.ToString());
                                Console.WriteLine("Saving image " + photoName);
                                photo.ImageNormal.Save(photoName, imageFormat);
                                imgName++;
                                albumSaverProgress.IncrementNumPhotosDownloaded();
                            }
                        }).Start();
                }
            }
        }
    }
}
