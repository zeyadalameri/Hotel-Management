# Zeyad Hotel Management System

Windows Forms hotel management system built with C# and .NET Framework 4.7.2.

## محتوى المشروع

- إدارة الغرف
- تسجيل العملاء
- تسجيل الخروج
- تفاصيل العملاء
- إدارة الموظفين
- صور وأيقونات واجهة الدخول ولوحة التحكم داخل مجلد `pictures`
- ملف SQL لإنشاء قاعدة البيانات والجداول وحساب دخول افتراضي

## التشغيل

1. افتح ملف الحل `zeyadhotel.sln` باستخدام Visual Studio.
2. نفّذ ملف `SQLQuery1.sql` في SQL Server لإنشاء قاعدة البيانات والجداول.
3. افتح ملف `zeyadhotel/App.config` وتأكد أن `Data Source` مناسب لاسم SQL Server عندك.
   - الافتراضي: `Data Source=.;Initial Catalog=Hotel;Integrated Security=True`
4. شغّل المشروع من Visual Studio.

## بيانات الدخول الافتراضية

- Username: `zeyad`
- Password: `1234`

## آخر التعديلات

- إزالة الاتصال القديم المرتبط بجهاز محدد.
- إضافة connection string في `App.config`.
- إصلاح تسجيل الدخول ليستخدم معاملات آمنة بدل دمج النصوص داخل SQL.
- إصلاح ملف سجل العمليات ليعمل بمسار نسبي داخل المشروع بدل مسار جهاز قديم.
- إضافة جدول الموظفين وحساب مدير افتراضي داخل ملف SQL.
