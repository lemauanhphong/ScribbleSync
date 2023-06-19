FROM python:3.8

COPY . /app
WORKDIR /app

EXPOSE 2808

CMD cp ./hosts /etc/hosts && python load_balancer.py
