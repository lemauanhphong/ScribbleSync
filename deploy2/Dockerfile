FROM python:3.8

RUN apt update -y && \
    apt install libmariadb3 libmariadb-dev -y

COPY . /app

WORKDIR /app/

RUN pip install -r requirements.txt

WORKDIR /app/server

EXPOSE 2808

CMD ["python", "server.py"]
