// See https://aka.ms/new-console-template for more information
using Renci.SshNet;

var sshClient = new SshClient("IP", "Username", "password");
sshClient.Connect();
var command = sshClient.CreateCommand("ls");

var result = command.Execute();
Console.WriteLine(result);

