foreach(var p in Process.GetProcessByName("Taskmgr.exe"))
{
    var process = true;
    while(process)
      {
        Process.Kill();
      }
}
