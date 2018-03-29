export type Toast = {
    id: string,
    content: string,
    visible: boolean,
    where: 'top' | 'bottom',
    type: 'success' | 'error' | 'info'
}