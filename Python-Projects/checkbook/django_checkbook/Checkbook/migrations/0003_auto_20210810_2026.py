# Generated by Django 3.2.6 on 2021-08-11 00:26

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('Checkbook', '0002_auto_20210810_2023'),
    ]

    operations = [
        migrations.RenameModel(
            old_name='Accounts',
            new_name='Account',
        ),
        migrations.RenameModel(
            old_name='Transactions',
            new_name='Transaction',
        ),
    ]
