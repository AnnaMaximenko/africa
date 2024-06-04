<!-- eslint-disable vue/multi-word-component-names -->
<template>
  <!-- <form
    action="https://localhost:7272/api/Applications"
    method="POST"
    id="myDropdown"
    class="form"
    @submit.prevent="send"
  >
    <h3 class="form__title">Application form</h3>
    <input
      placeholder="Name"
      required
      class="form__input"
      type="text"
      name="name"
      id=""
 
      v-model.trim="form.name"
      --
    />
    />
    <input
      placeholder="Phone"
      required
      class="form__input"
      type="tel"
      name="phone"
      id=""
      v-model.trim="form.phone"
    />
    <input
      placeholder="E-mail"
      required
      class="form__input"
      type="email"
      name=""
      id=""
      v-model.trim="form.email"
    />
    <button type="submit" class="form__button">Send</button>

    <div class="reviews">
      <ul>
        <li v-for="item in form" :key="item.id">
          <p>{{ item.name }}</p>
        </li>
      </ul>
    </div>
  </form> -->
  <form
    action="https://localhost:7272/api/Applications"
    method="POST"
    id="myDropdown"
    class="form center"
  >
    <h3 class="form__title">Application form</h3>
    <input
      placeholder="Name"
      required
      class="form__input"
      type="text"
      name="name"
      id=""
    />
    <input
      placeholder="Phone"
      required
      class="form__input"
      type="tel"
      name="phone"
      id=""
    />
    <input
      placeholder="E-mail"
      required
      class="form__input"
      type="email"
      name=""
      id=""
    />
    <button type="submit" class="form__button">Send</button>
  </form>
</template>
