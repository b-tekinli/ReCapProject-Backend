# ReCapProject - Araç Kiralama Sistemi

![.](https://user-images.githubusercontent.com/77868230/107869922-c395d300-6ea4-11eb-9aab-12f9d5805555.png) 
Bu repo **Yazılım Geliştirici Yetiştirme Kampı**'nda yapılan çalışmaları kapsayan **Araç Kiralama Projesi**'ni içerir.
## :pushpin: Getting Started
N-Katmanlı mimari yapısı ile hazırlanan, EntityFramework kullanılarak CRUD işlemlerinin yapıldığı, Wpf arayüzü ile çalışan, Araç Kiralama iş yerlerine yönelik örnek bir proje.
## :books:Layers  
![entities](https://user-images.githubusercontent.com/77868230/107870096-c5609600-6ea6-11eb-82e6-8e797c8a3617.png)
### Entities Layer
Veritabanı nesneleri için oluşturulmuş **Entities Katmanı**'nda **Abstract** ve **Concrete** olmak üzere iki adet klasör bulunmaktadır.Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmak için oluşturulmuştur.  
<br>:file_folder:`Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: ~~IEntity.cs~~ (Ortak Kod Olduğu İçin Core Katmanına Aktarıldı.)
<br> <br> :file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: Brand.cs   <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: Car.cs     <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: Color.cs   <br />
<br>
![business](https://user-images.githubusercontent.com/77868230/107870095-c5609600-6ea6-11eb-901d-9e7c21c3b614.png)
###  Business Layer
Sunum katmanından gelen bilgileri gerekli koşullara göre işlemek veya denetlemek için oluşturulan **Business Katmanı**'nda **Abstract**,**Concrete**,**Utilities** ve **ValidationRules** olmak üzere dört adet klasör bulunmaktadır.Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmak için oluşturulmuştur.Utilities ve ValidationRules klasörlerinde validation işlemlerinin gerçekleştiği classlar mevcuttur.  
<br>:file_folder:`Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: ICarService.cs     <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: IColorService.cs   <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: IBrandService.cs   <br />
<br> <br> :file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: CarManager.cs       <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: ColorManager.cs     <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: BrandManager.cs     <br />
<br> :file_folder:`Utilities`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: ValidationTool.cs
<br> :file_folder:`ValidationRules`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `FluentValidation`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: CarValidator.cs   
<br>
![dal](https://user-images.githubusercontent.com/77868230/107870097-c5f92c80-6ea6-11eb-90e2-4bbd7f36c561.png)
###  Data Access Layer
Veritabanı CRUD işlemleri gerçekleştirmek için oluşturulan **Data Access Katmanı**'nda **Abstract** ve **Concrete** olmak üzere iki adet klasör bulunmaktadır.Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmak için oluşturulmuştur.  
<br>:file_folder:`Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: IBrandDal.cs         <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: ICarDal.cs           <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: IColorDal.cs         <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: IEntityRepository.cs <br />
<br> <br> :file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `EntityFramework`    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: EfBrandDal.cs        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: EfCarDal.cs          <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: EfColorDal.cs        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: NorthwindContext.cs  <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `InMemory`    
<br>
![core](https://user-images.githubusercontent.com/77868230/107870091-c42f6900-6ea6-11eb-863e-63d30fa2128c.png)



###  Core Layer
Bir framework katmanı olan **Core Katmanı**'nda **DataAccess**, **Entities**, **Utilities** olmak üzere 3 adet klasör bulunmaktadır.DataAccess klasörü DataAccess Katmanı ile ilgili nesneleri, Entities klasörü Entities katmanı ile ilgili nesneleri tutmak için oluşturulmuştur. Core katmanının .Net Core ile hiçbir bağlantısı yoktur.Oluşturulan core katmanında ortak kodlar tutulur. Core katmanı ile, kurumsal bir yapıda, alt yapı ekibi ilgilenir.  
> **⚠ DİKKAT: .**  
> Core Katmanı, diğer katmanları referans almaz.
<br> <br> :file_folder:`DataAccess`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: IEntityRepository.cs
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `EntityFramework`    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: EfEntityRepositoryBase.cs
<br> :file_folder:`Entities`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: IEntity.cs
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: IDto.cs

:file_folder:`Utilities`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Results`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: IResult.cs <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: IDataResult.cs  <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: DataResult.cs <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: ErrorDataResult.cs <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: ErrorResult.cs <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: Result.cs <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: SuccessDataResult.cs <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: SuccessResult.cs <br />

![tables](https://user-images.githubusercontent.com/77868230/107870093-c4c7ff80-6ea6-11eb-998a-6458f4feeacd.png)
### Veritabanı Oluşturma (localdb)
Araba Kiralama Projemiz localdb ile çalışmaktadır. **LocalDb**'de veritabanı oluşturmak için **Visual Studio 2019** için *View > SQL Server Object Explorer* menü yolunu takip edebilirsiniz.Pencere açıldıktan sonra *SQL Server > (localdb)MSSQLLocalDB* altındaki **Databases** klasörüne sağ tıklayıp Add **New Database** seçeneğini ile veritabanınızı oluşturabilirsiniz. Veritabanı oluşturulduktan sonra **New Query** seçerek aşağıda bulunan Sql File ile veritabanınızda olması gereken tabloları oluşturabilirsiniz.  
<br>
:file_folder:`Sql File`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: RecapProjectDb.sql
<br>
## Tables
Veritabanı tablolarınızı manuel de oluşturabilirsiniz. Tablolar,sutün ve veri tipleri hakkında bilgiler aşağıda listelenmiştir.   

![.](https://user-images.githubusercontent.com/77868230/107870677-7ec16a80-6eab-11eb-8f97-d8f367c49f0b.png)

<br><br>

![.](https://user-images.githubusercontent.com/77868230/107105506-d02c8280-6837-11eb-865f-b2f3b8f4e779.png)

```
EntityFrameworkCore.SqlServer 3.1.11
FluentValidation 7.3.3
```
## :computer:ScreenShots
Projenin çalışma anına ait ekran görüntüleri  <br> <br>
![image](https://user-images.githubusercontent.com/77868230/107650244-52310700-6c8f-11eb-8e11-5e974c97917c.png)
![image](https://user-images.githubusercontent.com/77868230/107650330-6c6ae500-6c8f-11eb-961d-96edc3c7184b.png)
![image](https://user-images.githubusercontent.com/77868230/107650393-80164b80-6c8f-11eb-98f2-d05a9d57617e.png)
![image](https://user-images.githubusercontent.com/77868230/107650516-9de3b080-6c8f-11eb-82b5-99ed1b097dab.png)
![image](https://user-images.githubusercontent.com/77868230/107650566-ad62f980-6c8f-11eb-9776-9b10432a06b7.png) 

