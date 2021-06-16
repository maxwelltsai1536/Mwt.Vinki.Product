在docker里部署netcore项目

1、添加DockerFile

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
COPY . .
ENTRYPOINT ["dotnet", "Mwt.Vinki.Product.Web.dll"]

2、切换到项目发布目录（dockerFile始终复制）

docker build -t mwt.vinki .

3、将创建好的mwt.vinki镜像放到容器里启动

docker run --name=ps.mwt.vinki -p 9099:80 -d mwt.vinki

至此应该就能运行起来了

错误汇总

1、想要查看日志需进入docker容器内

docker exec -it 容器id bash 

2、找到日志目录，将日志复制到宿主机器

docker cp 容器id:/文件所在目录/logs.txt c:/

3、从宿主机替换文件到容器

docker cp c:/appsettings.json 容器id:/文件所在目录/appsettings.json

4、替换配置文件后重启容器

docker restart 容器id

