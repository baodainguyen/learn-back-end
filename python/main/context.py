from flask_sqlalchemy import SQLAlchemy
import pymysql
from serialize import Table

conn = "mysql+pymysql://root:root@db/data_ms"  #user:pass@host/db_name

def config(app):
    app.config['SECRET_KEY']='SuperSecretKey'
    app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
    app.config['SQLALCHEMY_DATABASE_URI'] = conn

    db = SQLAlchemy(app)

    class products_product(db.Model):
        id = db.Column(db.Integer, primary_key=True)
        title = db.Column(db.String(200))
        image = db.Column(db.String(200))
        likes = db.Column(db.Integer)

        def __repr__(self):
            return "id: {0} | title: {1} | image: {2} | likes: {3}".format(self.id, self.title, self.image, self.likes)

    return Context(db=db, mapper=products_product)

class Context:
    def __init__(self, db, mapper):
        self.db = db
        self.map = mapper
        
    def getProducts(self):
        products = self.map.query.all()
        oupt = Table.serialize(products)
        return oupt

    def getProduct(self, _id):
        product = self.map.query.filter_by(id=_id).first()
        outp = Table.serialize(product)
        return outp

    def updateLike(self, _id):
        product = self.map.query.filter_by(id=_id).first()
        likes = product.likes
        product.likes = likes + 1
        self.db.session.commit()
        return Table.serialize(product)
