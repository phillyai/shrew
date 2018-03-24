# Shrew

[![Build](https://img.shields.io/appveyor/ci/phillyai/shrew/master.svg)](https://ci.appveyor.com/project/phillyai/shrew)
[![Tests](https://img.shields.io/appveyor/tests/phillyai/shrew/master.svg)](https://ci.appveyor.com/project/phillyai/shrew/build/tests)

모든 것이 매크로로 이루어진 엘릭서와 모든 것이 프로시저인 LISP 계열 언어처럼 모든 게 패턴인 언어

## 1차 MVP

파라미터가 없이 단순 대입만 존재.

```c
a = 1
b = a + 3

main = a + b // main return 5
```

연산자는 괄호와 사칙연산 (+ - * /) 네 개를 지원하고 자료형은 정수, 실수, 부울 세 가지.
리터럴은 최소한만 생각함