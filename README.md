# 🏨 Zeyad Hotel Management System

![C#](https://img.shields.io/badge/C%23-.NET%204.7.2-blue?logo=csharp) ![Platform](https://img.shields.io/badge/Platform-Windows-lightgrey?logo=windows) ![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-red?logo=microsoftsqlserver)

نظام إدارة فندقي متكامل مبني بـ **C#** و **Windows Forms** و **.NET Framework 4.7.2**، يغطي إدارة الغرف والعملاء والموظفين.

---

## 📸 Screenshots

### شاشة تسجيل الدخول
![Login](pictures/login%20image.jpg)

---

## ✨ المميزات

- 🛌 **إدارة الغرف** — إضافة وتعديل وحذف الغرف
- 👤 **تسجيل العملاء** — حجز وتسجيل بيانات العميل
- 🚶 **تسجيل الخروج** — معالجة عمليات المغادرة
- 📄 **تفاصيل العملاء** — عرض وتعديل بيانات العميل
- 👨‍💼 **إدارة الموظفين** — إضافة وتعديل بيانات الموظفين
- 🔒 **تسجيل دخول آمن** — استخدام Parameterized Queries لحماية SQL Injection
- 📅 **سجل العمليات** — تتبع جميع العمليات بمسار نسبي

---

## 🛠️ التقنيات المستخدمة

| التقنية | الوصف |
|---|---|
| C# | لغة البرمجة |
| .NET Framework 4.7.2 | الإطار |
| Windows Forms | واجهة المستخدم |
| SQL Server | قاعدة البيانات |
| Visual Studio | بيئة التطوير |

---

## 🚀 طريقة التشغيل

1. افتح ملف الحل `zeyadhotel.sln` باستخدام **Visual Studio**
2. نفّذ ملف `SQLQuery1.sql` في **SQL Server** لإنشاء قاعدة البيانات
3. افتح `zeyadhotel/App.config` وتأكد من إعداد الاتصال:
```xml
Data Source=.;Initial Catalog=Hotel;Integrated Security=True
```
4. شغّل المشروع من Visual Studio ▶️

---

## 🔐 بيانات الدخول الافتراضية

| الحقل | القيمة |
|---|---|
| Username | `zeyad` |
| Password | `1234` |

---

## 👤 المطور

**Zeyad Al-Ameri**  
[![GitHub](https://img.shields.io/badge/GitHub-zeyadalameri-black?logo=github)](https://github.com/zeyadalameri)
