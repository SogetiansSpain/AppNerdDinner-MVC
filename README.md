NERD DINNER MATERIAL PARA FORMACION ASP.NET MVC3
--------------------------------------------------------------------------------

Este repositorio contiene la solucion original Microsoft que sirve como guia de ejemplo y aprendizaje.

Para realizar el tutorial se ha migrado la solucion a Visual Studio 2017

La solucion original estaba con Visual Studio 2010, se han tenido que realizar ajustes en los paquetes de MVC.

Dentro de VS2017 en Consola Nuget se ha realizado el siguiente comando:

PM> Install-Package Microsoft.AspNet.Mvc -Version 3.0.50813.1

Despues del comando Nuget se pueden ver los cambios en web.config

  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="Microsoft.VisualStudio.Enterprise.AspNetHelper" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
        <codeBase version="10.0.0.0" href="file:///C:/Program%20Files%20(x86)/Microsoft%20Visual%20Studio%2010.0/Common7/IDE/PrivateAssemblies/Microsoft.VisualStudio.Enterprise.AspNetHelper.DLL" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="System.Web.Mvc" publicKeyToken="31bf3856ad364e35" />
        <bindingRedirect oldVersion="0.0.0.0-3.0.0.1" newVersion="3.0.0.1" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>

Tambien se debe añadir via nuget el proveedor Microsoft SQL Server Compact Data Provider 4.0:

  <system.data>
    <DbProviderFactories>
      <remove invariant="System.Data.SqlServerCe.4.0" />
      <add name="Microsoft SQL Server Compact Data Provider 4.0" invariant="System.Data.SqlServerCe.4.0" description=".NET Framework Data Provider for Microsoft SQL Server Compact" type="System.Data.SqlServerCe.SqlCeProviderFactory, System.Data.SqlServerCe, Version=4.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" />
    </DbProviderFactories>
  </system.data>
