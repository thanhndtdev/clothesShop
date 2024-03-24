const INITIAL_STATE = {
    account: {
        access_token: '',
        userName: '',
        role: '',
        userid: ''
    },
    isAuthenticated: false
}

const userReducer = (state = INITIAL_STATE, action) => {
    switch (action.type) {
        case 'FETCH_USER_LOGIN_SUCCESS':
            return {
                ...state, account: {
                    access_token: action.payload.data,
                    userName: action.payload.username,
                    role: action.payload.roleid,
                    userid: action.payload.userId
                },
                isAuthenticated: true

            }
        default:
            return state;
    }
}
export default userReducer;