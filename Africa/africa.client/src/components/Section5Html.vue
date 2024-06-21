<template>
  <section class="section-five center">
    <div class="subtitle__wrapper section-five__subtitle">
      <svg
        width="38"
        height="38"
        viewBox="0 0 38 38"
        fill="none"
        xmlns="http://www.w3.org/2000/svg"
      >
        <path
          d="M0 17.8084H13.6135L1.26944 12.0663L2.27449 9.90541L13.9361 15.3306L5.15123 5.93771L6.89122 4.3094L15.4871 13.4999L10.7654 1.83543L12.974 0.9411L17.8084 12.8814V0H20.1916V12.8814L25.025 0.9411L27.2346 1.83543L22.5119 13.4999L31.1078 4.3094L32.8488 5.93771L24.0639 15.3306L35.7246 9.90541L36.7296 12.0663L24.3865 17.8084H38V20.1916H24.3865L36.7296 25.9337L35.7246 28.0946L24.0639 22.6704L32.8488 32.0632L31.1078 33.6916L22.5119 24.5001L27.2346 36.1646L25.025 37.0589L20.1916 25.1195V38H17.8084V25.1195L12.974 37.0589L10.7654 36.1646L15.4871 24.5001L6.89122 33.6916L5.15123 32.0632L13.9361 22.6704L2.27449 28.0946L1.26944 25.9337L13.6135 20.1916H0V17.8084Z"
          fill="#A86747"
        />
      </svg>
      <p class="subtitle__text_white">DESTINATION</p>
    </div>
    <h2 class="section-five__title">
      IN AFRICA WE SAY O AMOGETSWE, YOU ARE AWAYS WELCOME.
    </h2>
    <div class="section-five__box">
      <div class="section-five__wrapper-left">
        <hr class="section-five__hr" />
        <p class="section-five__text">
          Sed tincidunt quis amet ut. Augue et pellentesque quis sit tempus
          placerat vitae. Nunc potenti donec blandit quis sit. Faucibus purus
          odio sit massa id. Dolor quis mauris nisi mauris. Cras suspendisse mi
          tempus elementum proin nibh et elit. Mollis euismod cras in diam
          pretium etiam.
        </p>
        <a id="link" href="#myDropdown" class="section-five__button-main"
          >PLAN A TRIP</a
        >
      </div>
      <div class="section-five__wrapper-right">
        <!-- <div class="section-five__picture">
          <div class="section-five__ornament"></div>
          <div class="section-five__slider"></div>
        </div>
        <div class="section-five__button-box">
          <button class="section-five__button">01</button>
          <button class="section-five__button">02</button>
          <button class="section-five__button">03</button>
          <button class="section-five__button">04</button>
          <button class="section-five__button">05</button>
        </div> -->
        <div class="section-five__slider">
          <input type="radio" name="images" id="img1" checked />
          <input type="radio" name="images" id="img2" />
          <input type="radio" name="images" id="img3" />
          <input type="radio" name="images" id="img4" />
          <input type="radio" name="images" id="img5" />
          <div class="section-five__slider-img" id="one">
            <img src="../assets/img/section-5__lion.webp" alt="leon" />
            <label for="img3" class="section-five__prev">1</label>
            <label for="img2" class="section-five__next"></label>
          </div>
          <div class="section-five__slider-img" id="two">
            <img src="../assets/img/section-5__elephant.jpg" alt="" />
            <label for="img1" class="section-five__prev"></label>
            <label for="img3" class="section-five__next"></label>
          </div>
          <div class="section-five__slider-img" id="three">
            <img src="../assets/img/section-5__leopard.jpg" alt="" />
            <label for="img2" class="section-five__prev"></label>
            <label for="img1" class="section-five__next"></label>
          </div>
          <div class="section-five__slider-img" id="four">
            <img src="../assets/img/section-5__hippo.jpg" alt="" />
            <label for="img3" class="section-five__prev"></label>
            <label for="img5" class="section-five__next"></label>
          </div>
          <div class="section-five__slider-img" id="five">
            <img src="../assets/img/section-5__zebra.jpg" alt="" />
            <label for="img4" class="section-five__prev"></label>
            <label for="img1" class="section-five__next"></label>
          </div>

          <div class="section-five__counter">
            <label for="img1" class="section-five__count" id="count1">01</label>
            <label for="img2" class="section-five__count" id="count2">02</label>
            <label for="img3" class="section-five__count" id="count3">03</label>
            <label for="img4" class="section-five__count" id="count4">04</label>
            <label for="img5" class="section-five__count" id="count5">05</label>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
<script></script>
