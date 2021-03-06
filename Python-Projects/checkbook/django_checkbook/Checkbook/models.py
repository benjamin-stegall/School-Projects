from django.db import models

# Create your models here.


class Account(models.Model):
    first_name = models.CharField(max_length=50)
    last_name = models.CharField(max_length=50)
    initial_deposit = models.DecimalField(decimal_places=2, max_digits=15)

    Accounts = models.Manager()

    # Displays first name
    def __str__(self):
        return self.first_name + ' ' + self.last_name


TransactionTypes = [('Deposit', 'Deposit'),('Withdrawal', 'Withdrawal')]


class Transaction(models.Model):
    date = models.DateField()
    type = models.CharField(max_length=10, choices=TransactionTypes)
    amount = models.DecimalField(decimal_places=2, max_digits=15)
    description = models.CharField(max_length=100)
    account = models.ForeignKey(Account, on_delete=models.CASCADE)

    Transactions = models.Manager()
