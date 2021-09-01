from flask import Flask
from flask.ext.sqlalchemy import SQLAlchemy



app = Flask(__name__)

from my_app.product.views import product
app.register_blueprint(product)

db.create_all()
