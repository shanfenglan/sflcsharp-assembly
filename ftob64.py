#!/usr/bin/python3
# -*- coding: utf-8 -*-
# @Time    : 2020/9/17 15:58
# @Author  : shanfenglan
# @File    : ftob64.py
# @Software: PyCharm
import base64, sys,time
name = "b64-"+ str(time.gmtime().tm_min)+ "-"+ str(time.gmtime().tm_sec)
# path = sys.argv[1]
path = "/Users/shukasakai/Desktop/helloworld.exe"

with open(path, 'rb') as f:  # 以二进制读取图片
    data = f.read()
    encodestr = base64.b64encode(data)  # 得到 byte 编码的数据

with open("/Users/shukasakai/Desktop/{0}.txt".format(name),'wb+') as f:
    f.write(encodestr)