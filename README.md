# Filewatcher
watches given locations for changes in files (TDMS) and invokes a script (you can store your paths in the program) 
This Program is made by Marcel Groesbeek /Mhgsys and is running on multiple machines in a company that calibrates 
Relative Humidity Sensors

                example script to invoke: (just an example)

#Make your own script and save it to your desired location.
#Don't forget to make the changes in the FileWatcher Program afterwards.

$ImagesFolder = 'C:\Users\marce\OneDrive\Bureaublad\'
$BackupImagesFolder = 'G:\'

$ImagesFiles = Get-ChildItem -Path $ImagesFolder
$BackUpImagesFiles = (Get-ChildItem -Path $BackupImagesFolder).Name

foreach($image in $ImagesFiles)
{
    $fileName = $image.Name;
    if($BackUpImagesFiles -notcontains $fileName)
    {
        Copy-Item $image.FullName -Destination $BackupImagesFolder
    }
}

                    HOWTO CALL MY SCRIPT?
Go to the settings in FileWatcher program (click the gears)
and select the scripts location.


                    LOGIN Details:

Username = Admin
Password = System32!

