# Generated by Django 3.2.6 on 2021-08-11 00:43

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('Checkbook', '0003_auto_20210810_2026'),
    ]

    operations = [
        migrations.AlterField(
            model_name='transaction',
            name='description',
            field=models.CharField(max_length=100),
        ),
    ]
