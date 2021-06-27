FROM python:3.9
ENV PYTHONUNBUFFERED 1
WORKDIR /app
COPY require.txt /app/require.txt
RUN pip install -r require.txt
COPY . /app
