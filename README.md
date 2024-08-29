# InternProject
# İşçi İdarəetmə Sistemi

## Proyekt Təsviri
İşçi İdarəetmə Sistemi, işçi, departman və ünvan idarəçiliyini həyata keçirən bir .NET 6 Web API proyektidir. Bu proyekt, Entity Framework Core və JWT (JSON Web Token) istifadə edərək məlumatların idarə olunmasını və şəxsiyyət doğrulamasını təmin edir. Ayrıca, istifadəçi rollarına görə yetkiləndirmə həyata keçirir və seed datalar istifadə edərək başlanğıc məlumatlarını təmin edir.

## Texnologiyalar
- .NET 6
- Entity Framework Core
- JWT (JSON Web Token)
- Swagger
- Docker

## Proyekt Xüsusiyyətləri

### 1. İstifadəçi Rolları və Yetkiləndirmə
Proyekt, iki əsas istifadəçi rolunu ehtiva edir:

- **Admin**: Bütün CRUD əməliyyatlarını (Create, Read, Update, Delete) həyata keçirə bilən idarəçi yetkilərinə malikdir.
- **User**: Bütün POST və GET əməliyyatlarını həyata keçirə bilər, lakin DELETE və PUT əməliyyatlarını edə bilmir.

JWT istifadə edərək şəxsiyyət doğrulama həyata keçirilir. İstifadəçilər sistemə daxil olduqdan sonra bir token əldə edir və bu token ilə qorunan endpointlərə giriş təmin edirlər.

### 2. Seed Məlumatlar
Proyektdə başlanğıc məlumatları olaraq seed datalar istifadə olunur. Bu seed məlumatlar, proyekt işlədildiyi zaman avtomatik olaraq verilənlər bazasına əlavə olunur.

- **Departamentlər**: Operations, Sales, Development
- **Adreslər**: Müxtəlif ünvanlar, hər bir ünvan bir işçi ilə əlaqələndirilmişdir.
- **İşçilər**: Hər işçi müəyyən bir departamentə mənsub ola bilər və bir ünvanla əlaqəlidir.
- **User Seed Data**:
  - Email: `user@gmail.com`
  - Password: `Aslan2004`
- **Admin Seed Data**:
  - Email: `admin@gmail.com`
  - Password: `Aslan2004`

### 3. Model Əlaqələri
- **İşçi**: Bir işçi yalnız bir departamentə mənsub ola bilər və bir ünvanı ola bilər.
- **Departament**: Bir departamentdə bir neçə işçi ola bilər.
- **Ünvan**: Hər bir ünvan yalnız bir işçiyə aid ola bilər.

### 4. API Endpointləri

**Employee Endpointləri**
- GET /employees : Bütün işçiləri siyahıya alır. (Admin və User)
- GET /employees/{id} : Müəyyən bir işçini göstərir. (Admin və User)
- POST /employees : Yeni işçi əlavə edir. (Admin və User)
- PUT /employees/{id} : Müəyyən bir işçini yeniləyir. (Yalnız Admin)
- DELETE /employees/{id} : Müəyyən bir işçini silir. (Yalnız Admin)

**Department Endpointləri**
- GET /departments : Bütün departamentləri siyahıya alır. (Admin və User)
- GET /departments/{id} : Müəyyən bir departamenti göstərir. (Admin və User)
- POST /departments : Yeni departament əlavə edir. (Admin və User)
- PUT /departments/{id} : Müəyyən bir departamenti yeniləyir. (Yalnız Admin)
- DELETE /departments/{id} : Müəyyən bir departamenti silir. (Yalnız Admin)

**Address Endpointləri**
- GET /addresses : Bütün ünvanları siyahıya alır. (Admin və User)
- GET /addresses/{id} : Müəyyən bir ünvanı göstərir. (Admin və User)
- POST /addresses : Yeni ünvan əlavə edir. (Admin və User)
- PUT /addresses/{id} : Müəyyən bir ünvanı yeniləyir. (Yalnız Admin)
- DELETE /addresses/{id} : Müəyyən bir ünvanı silir. (Yalnız Admin)

**Auth Endpointləri**
- POST /Auth/Register : Yeni istifadəçi qeydiyyatı üçün istifadə olunur. Heç bir rol tələb olunmur.
- POST /Auth/Login : Sistemdə mövcud olan bir istifadəçinin daxil olması üçün istifadə olunur. Heç bir rol tələb olunmur.

## Quraşdırma və İşlədilmə

### Tələblər
- Docker

### Proyektin İşlədilmə

**Docker ilə İşlədilmə**

1. Proyekt yoluna keçin:

```bash
cd [proyekt-path]
```
2.Docker Compose ilə konteynerləri yaradın və başladın:
docker-compose up --build
3.API-nin işlədiyini təsdiq etmək üçün brauzerinizdə və ya Postman kimi bir alətdə aşağıdakı URL-i istifadə edə bilərsiniz:
Swagger interfeysi: `http://localhost:8002/swagger`

4.Docker Konteynerlərini Dayandırma və Qaldırma
Docker konteynerlərini dayandırın və çıxarın:
docker-compose down


Müəllif
Backend Developer Aslan Abdulrazagov