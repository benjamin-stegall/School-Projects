# Generated by Django 3.2.6 on 2021-08-11 00:23

from django.db import migrations, models
import django.db.models.deletion
import django.db.models.manager


class Migration(migrations.Migration):

    dependencies = [
        ('Checkbook', '0001_initial'),
    ]

    operations = [
        migrations.CreateModel(
            name='Transactions',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('date', models.DateField()),
                ('type', models.CharField(choices=[('Deposit', 'Deposit'), ('Withdrawal', 'Withdrawal')], max_length=10)),
                ('amount', models.DecimalField(decimal_places=2, max_digits=15)),
                ('description', models.TextField(max_length=100)),
            ],
            managers=[
                ('Transactions', django.db.models.manager.Manager()),
            ],
        ),
        migrations.RenameModel(
            old_name='Account',
            new_name='Accounts',
        ),
        migrations.DeleteModel(
            name='Transaction',
        ),
        migrations.AddField(
            model_name='transactions',
            name='account',
            field=models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='Checkbook.accounts'),
        ),
    ]