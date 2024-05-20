<!-- eslint-disable vue/multi-word-component-names -->
<template>
    <header>
        <div id="app" class="header__wrapper center">
            <a href="#">
                <img src="../assets/img/Logo_Frika Safaris.svg" alt="logo" />
            </a>
            <div class="header-right__menu">
                <router-link class="header__menu"
                             v-for="link in rightArr"
                             :key="link.id"
                             :to="link.url">
                    {{ link.name }}
                </router-link>
                <div class="header__dropdown">
                    <button @click="show = !show" key="menu" class="header__button">
                        PLAN A TRIP
                    </button>

                    <form @submit.prevent = "onSendApplication" v-if="show" id="myDropdown" class="form">
                        <h3 class="form__title">Application form</h3>
                        <input placeholder="Name"
                               v-model ="applicationData.name"
                               required
                               class="form__input"
                               type="text"
                               name="name"
                               id="" />
                        <input placeholder="Phone"
                               v-model ="applicationData.phone"
                               required
                               class="form__input"
                               type="tel"
                               name="phone"
                               id="" />
                        <input placeholder="E-mail"
                               v-model ="applicationData.email"
                               required
                               class="form__input"
                               type="email"
                               name=""
                               id="" />
                        <button class="form__button">Send</button>
                    </form>
                </div>
            </div>
        </div>
    </header>
</template>

<script>
    import axios from 'axios';
    export default {
        data() {
            return {
                applicationData:{
                    name: '',
                    phone: '',
                    email: '',
                },
                rightArr: [
                    { id: 0, name: "Destinations", url: "/" },
                    { id: 1, name: "About Us", url: "/" },
                    { id: 2, name: "Experience", url: "/" },
                    { id: 3, name: "Blog", url: "/" },
                ],
                show: false,
            };
        },
        methods: {
            onSendApplication() {
                return axios.post('https://localhost:7272/api/Applications', this.applicationData);
            }
        },
    };
</script>

<style lang="scss" scoped></style>
