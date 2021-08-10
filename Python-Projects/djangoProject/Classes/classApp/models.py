from django.db import models

# Create your models here.

class djangoClasses(models.Model):
    # Defining class...
    title = models.CharField(max_length=100)
    course_id = models.IntegerField()
    instructor_name = models.CharField(max_length=50)
    duration = models.DecimalField(default=0.00, decimal_places=1, max_digits=1000)

    objects = models.Manager()

    # Displays the title of the object
    def __str__(self):
        return self.title
